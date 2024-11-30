using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.models;

namespace UamAcces.Formularios
{
    public partial class FrmLogin2 : MaterialForm
    {
        AdministrationUser administration = new AdministrationUser();
        Administration admincurrent = new Administration();
        public FrmLogin2()
        {
            InitializeComponent();
            TbCif.Focus();
            administration.ReadFile();
            admincurrent.ReadFile();
            TextBoxTab(this);
        }

        private void BtmIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int cif = int.Parse(TbCif.Text);
                int password = int.Parse(TbPassword.Text);
                if (administration.Verification(cif, password))
                {
                    if (admincurrent.DataVerification(cif))
                    {
                        Exit exit = new Exit(admincurrent.GetUser(cif));
                        this.Hide();
                        exit.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Entry entry = new Entry(administration.Find(cif, password));
                        this.Hide();
                        entry.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("CIF o Contraseña incorrecta", "Datos erróneos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TbCif.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese bien los datos", "Error de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }


        private void TextBoxTab(Control parent)
        {
            foreach (Control control in parent.Controls)
            {

                if (control is TextBox || control is ComboBox || control is RadioButton)
                {
                    control.PreviewKeyDown -= Control_PreviewKeyDown;
                    control.PreviewKeyDown += Control_PreviewKeyDown;
                }


                if (control.HasChildren)
                {
                    TextBoxTab(control);
                }
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
                Control currentControl = (Control)sender;
                bool forward = !e.Shift;


                Control parent = currentControl.Parent;
                while (!parent.SelectNextControl(currentControl, forward, true, true, false))
                {

                    if (parent.Parent == null) break;
                    parent = parent.Parent;
                }
            }
        }

        private void BtmReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Salir?", "Salida",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Input input = new Input();
                this.Hide();
                input.ShowDialog();
                this.Close();
            }
        }

        private void TbCif_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se introducen letras", "Error de datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void TbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se introducen letras", "Error de datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
