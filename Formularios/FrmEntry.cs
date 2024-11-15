using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.models;

namespace UamAcces.Formularios
{
    public partial class Entry : MaterialForm
    {
        Administration administration= new Administration();
        User user = new User();
        string typeaccess, wayaccess;
        public Entry( User user1)
        {
            InitializeComponent();
            administration.ReadFile();
            user = user1;
            LblWelcome.Text = $"¡Bienvenido {user.Name} {user.LastName}!";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: ";
            lblHora.Text += DateTime.Now.ToString("hh:mm:ss tt");
            lblDia.Text = $"Día: {DateTime.Today.ToString("dd/MM/yyyy")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entrant entrant = new Entrant();
                entrant.CIF = user.CIF;
                entrant.Name = user.Name;
                entrant.LastName = user.LastName;
                entrant.Entry=DateTime.Now;
                entrant.EntryPath = wayaccess;
                entrant.EntryType= typeaccess;
                entrant.Plate= TbPlate.Text;

                DialogResult aswer = MessageBox.Show("¿Seguro desea marcar asistencia?", "Asistencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (aswer == DialogResult.Yes)
                {
                    administration.Add(entrant);
                    Input input = new Input();
                    input.ShowDialog();
                }
                

            }catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Error de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

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

        private void RbVehicular_CheckedChanged(object sender, EventArgs e)
        {
            TbPlate.Enabled= true;
            typeaccess= RbVehicular.Text;
        }

        private void RbPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            wayaccess= RbPrincipal.Text;
        }

        private void RbResidential_CheckedChanged(object sender, EventArgs e)
        {
            wayaccess = RbResidential.Text;
        }

        private void RbPedestrian_CheckedChanged(object sender, EventArgs e)
        {
            TbPlate.Enabled = false;
            typeaccess = RbPedestrian.Text;
        }
    }
}
