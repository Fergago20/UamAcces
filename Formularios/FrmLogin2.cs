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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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
                        exit.ShowDialog();
                    }
                    else
                    {
                        Entry entry = new Entry(administration.Find(cif, password));
                        entry.ShowDialog();
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
                MessageBox.Show(ex.ToString(),"Error de Datos", MessageBoxButtons.OK
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
    }
}
