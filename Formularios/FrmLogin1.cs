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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cif= int.Parse(tbCif.Text);
                int password= int.Parse(tbPassword.Text);
                if (administrator.Validar(cif, password)) 
                { 
                    AdministratorUi administratorui = new AdministratorUi();
                    administratorui.ShowDialog();
                }else
                {
                    MessageBox.Show("Contraseña o CIF incorrecto", "Error de datos", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(),"Error de Inicio de sesion",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
