using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using UamAcces.Forms;

namespace UamAcces.Formularios
{
    public partial class AdministratorUi : MaterialForm
    {
        public AdministratorUi()
        {
            InitializeComponent();
        }

        private void btmHistorial_Click(object sender, EventArgs e)
        {
            Report1 report = new Report1();
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btmIngresados_Click(object sender, EventArgs e)
        {
            FrmReport2 report = new FrmReport2();
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void AdminUser_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            this.Hide();
            user.ShowDialog();
            this.Close();
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
