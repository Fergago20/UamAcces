using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.models;

namespace UamAcces.Formularios
{
    public partial class Entry : MaterialForm
    {
        Administration administration = new Administration();
        User user = new User();
        string typeaccess, wayaccess;
        public Entry(User user1)
        {
            InitializeComponent();
            administration.ReadFile();
            user = user1;
            LblWelcome.Text = $"¡Bienvenido {user.Name} {user.LastName}!";
            timer1.Enabled = true;
            TextBoxTab(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: ";
            lblHora.Text += DateTime.Now.ToString("hh:mm:ss tt");
            lblDia.Text = $"Día: {DateTime.Today.ToString("dd/MM/yyyy")}";
        }

        public bool VerificationCamp(Control container)
        {
            if (string.IsNullOrEmpty(wayaccess) || string.IsNullOrEmpty(typeaccess))
            {
                MessageBox.Show("Llene los datos solicitados", "Error de Datos", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (TbPlate.Enabled == true && !IsValidPlate(TbPlate.Text))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsValidPlate(string input)
        {
            
            if (input.Length != 8)
            {
                MessageBox.Show("Placa no existente", "Error de Placa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

            
            int letterCount = input.Count(char.IsLetter);
            int numberCount = input.Count(char.IsDigit);

            if (letterCount >= 1 && numberCount >= 2)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Placa no existente", "Error de Placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
           
        }

        private void BtmEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificationCamp(this))
                {
                    Entrant entrant = new Entrant();
                    entrant.CIF = user.CIF;
                    entrant.Name = user.Name;
                    entrant.LastName = user.LastName;
                    entrant.Role = user.Role;
                    entrant.Faculty = user.Faculty;
                    entrant.Entry = DateTime.Now;
                    entrant.EntryPath = wayaccess;
                    entrant.EntryType = typeaccess;
                    entrant.Plate = TbPlate.Text;

                    DialogResult aswer = MessageBox.Show("¿Seguro desea marcar asistencia?", "Asistencia",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (aswer == DialogResult.Yes)
                    {
                        administration.Add(entrant);
                        Input input = new Input();
                        this.Hide();
                        input.ShowDialog();
                        this.Close();
                    }
                }
                

            }catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Error de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
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
            TbPlate.Text = "";
            TbPlate.Enabled = false;
            typeaccess = RbPedestrian.Text;
        }

        private void TextBoxTab(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.PreviewKeyDown += TextBox_PreviewKeyDown;
                }

                if (control.HasChildren)
                {
                    TextBoxTab(control);
                }
            }
        }

        private void TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }
    }
}
