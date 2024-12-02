using MaterialSkin.Controls;
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
using UamAcces.Forms;
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
            TextBoxTab(this);
            TbCif.Focus();
        }

        private void Option()
        {
            CbFaculty.Items.Clear();
            CbRole.Items.Clear();
            string contenido1 = Properties.Resources.Facultades;
            string contenido2= Properties.Resources.Roles;

            
            string[] faculties = contenido1.Split(new[] 
            { Environment.NewLine }, StringSplitOptions.None);
            CbFaculty.Items.AddRange(faculties);

            string[] roles = contenido2.Split(new[]
            { Environment.NewLine }, StringSplitOptions.None);
            CbRole.Items.AddRange(roles);
        }

        private bool VerificationLong(int cif, int password)
        {
            int long1= cif.ToString().Length;
            int long2= password.ToString().Length;

            if(long1>= 4 && long2 >= 4)
            {
                return true;
            }
            return false;
        }

        private bool VerificationCamp(Control controlFather)
        {
            foreach (Control control in controlFather.Controls) 
            {
                if (!control.Enabled) continue; 

                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return false; 
                }
                else if (control is CheckBox checkBox)
                {
                    if (!checkBox.Checked)
                        return false; 
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex < 0)
                        return false; 
                }
                else if (control.HasChildren)
                {
                    
                    if (!VerificationCamp(control))
                        return false;
                }
            }

            return true;
        }



        private void AddUser_Click(object sender, EventArgs e)
        {
           
                User user = new User();
            if(VerificationCamp(this))
            {
                user = UserData();
                if (VerificationLong(user.CIF, user.Password))
                {
                    DialogResult aswer = MessageBox.Show("¿Seguro desea agregar a este usuario?", "Agregar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (aswer == DialogResult.Yes)
                    {
                        administration.AddUser(user, user.CIF, user.Password);
                        Clean();
                        TbCif.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La longitud del cif y la contraseña deben ser mayor de 4", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LookUser_Click(object sender, EventArgs e)
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
                if (!string.IsNullOrEmpty(TbCif.Text))
                {

                    int cif = int.Parse(TbCif.Text);
                    DialogResult answer = MessageBox.Show("¿Seguro desea eliminar a este usuario?", "Eliminar",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (answer == DialogResult.Yes)
                    { administration.DeleteUser(cif); Clean(); TbCif.Focus(); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtmUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                User user = new User();
                if (VerificationCamp(this))
                {
                    user = UserData();
                    if (VerificationLong(user.CIF, user.Password))
                    {
                        DialogResult answer = MessageBox.Show("¿Seguro desea actualizar a este usuario?", "Eliminar",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (answer == DialogResult.Yes)
                        { administration.Update(user, user.CIF); Clean(); }
                    }
                    else
                    {
                        MessageBox.Show("La longitud del cif y la contraseña deben ser mayor de 4", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void BtmReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Salir?", "Salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdministratorUi admin = new AdministratorUi();
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbRole.SelectedItem != null)
            {
                
                string selectedRole = CbRole.SelectedItem.ToString();

                if (selectedRole == "Externo")
                {
                   
                    CbFaculty.SelectedItem = "No Ligado"; 
                    CbFaculty.Enabled = false;
                    TbReason.Enabled = true;
                }
                else
                {
                    CbFaculty.Enabled = true;
                    TbReason.Enabled = false;
                    CbFaculty.SelectedIndex = -1;
                    TbReason.Clear();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewUser viewUser = new ViewUser();
            viewUser.Show();
        }

        private void BtmLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
