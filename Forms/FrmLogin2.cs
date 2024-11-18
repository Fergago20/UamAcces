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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void TbCif_KeyPress(object sender, KeyPressEventArgs e)
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
