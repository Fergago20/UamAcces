﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.models;

namespace UamAcces.Formularios
{
    public partial class AddUser : MaterialForm
    {
        AdministrationUser administration = new AdministrationUser(); 
        public AddUser()
        {
            InitializeComponent();
            administration.ReadFile();
            Option();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.FromArgb(55, 71, 79), 20))
            {
                e.Graphics.DrawRectangle(pen, 0, 0,
                    this.Width - 1, this.Height - 1);
            }
        }

        private void Option()
        {
            CbFaculty.Items.Clear();
            CbRole.Items.Clear();
            string contenido1 = Properties.Resources.Facultades;
            string contenido2= Properties.Resources.Roles;

            // Dividir el contenido en líneas
            string[] faculties = contenido1.Split(new[] 
            { Environment.NewLine }, StringSplitOptions.None);
            CbFaculty.Items.AddRange(faculties);

            string[] roles = contenido2.Split(new[]
            { Environment.NewLine }, StringSplitOptions.None);
            CbRole.Items.AddRange(roles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                User user = new User();
                user= UserData();
                DialogResult aswer= MessageBox.Show("¿Seguro desea agregar a este usuario?", "Agregar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (aswer == DialogResult.Yes)
                {
                    administration.AddUser(user, user.CIF, user.Password);
                Clean();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user=administration.Data(int.Parse(TbCif.Text));
                if (user != null)
                {
                    ShowData(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("¿Seguro desea eliminar a este usuario?", "Eliminar",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                { administration.DeleteUser(int.Parse(TbCif.Text)); Clean(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtmUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = UserData();
            DialogResult answer = MessageBox.Show("¿Seguro desea actualizar a este usuario?", "Eliminar",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            { administration.Update(user, user.CIF); Clean(); }
        }

        private User UserData()
        {
            try
            {
                User user = new User();
                user.CIF= int.Parse(TbCif.Text);
                user.Password= int.Parse(TbPassword.Text);
                user.Name= TbName.Text;
                user.LastName= TbLastName.Text;
                user.Role= CbRole.SelectedItem.ToString();
                user.Reason= TbReason.Text;
                user.Faculty= CbFaculty.SelectedItem.ToString();
                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada de datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void ShowData(User user)
        {
            TbCif.Text = user.CIF.ToString();
            TbPassword.Text = user.Password.ToString();
            TbName.Text = user.Name;
            TbLastName.Text = user.LastName;
            CbRole.SelectedItem = user.Role;
            TbReason.Text = user.Reason;
            CbFaculty.SelectedItem = user.Faculty;
        }

        private void Clean()
        {
            TbCif.Text = "";
            TbPassword.Text = "";
            TbName.Text = "";
            TbLastName.Text = "";
            CbRole.SelectedIndex=-1;
            TbReason.Text = "";
            CbFaculty.SelectedIndex=-1;
        }
    }
}