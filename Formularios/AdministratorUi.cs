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
            report.ShowDialog();
        }

        private void btmIngresados_Click(object sender, EventArgs e)
        {
            FinalReport final = new FinalReport();
            final.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.ShowDialog();
        }
    }
}
