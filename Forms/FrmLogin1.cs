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
using UamAcces.Formularios;
using UamAcces.models;

namespace UamAcces
{
    public partial class Form1 : MaterialForm
    {
        Administrator administrator = new Administrator();
        public Form1()
        {
            InitializeComponent();
            TbCif.Focus();
            this.KeyPreview=true;
            TextBoxTab(this);
        }



        private void BtmIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int cif = int.Parse(TbCif.Text);
                int password = int.Parse(TbPassword.Text);
                if (administrator.Validar(cif, password))
                {
                    AdministratorUi administratorui = new AdministratorUi();
                    this.Hide();
                    administratorui.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Contraseña o CIF incorrecto", "Error de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TbCif.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese bien los datos", "Error de Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Letter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se introducen letras", "Error de datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Letter2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se introducen letras", "Error de datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
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
    }
}
