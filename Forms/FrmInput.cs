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
    public partial class Input : MaterialForm
    {
        public Input()
        {
            InitializeComponent();
        }

        private void BtmAdmin_Click(object sender, EventArgs e)
        {
            Form1 login1 = new Form1();
            this.Hide();
            login1.ShowDialog();
            this.Close();
        }

        private void btmIngresar_Click(object sender, EventArgs e)
        {
            FrmLogin2 login2 = new FrmLogin2();
            this.Hide();
            login2.ShowDialog();
            this.Close();
        }
    }
}
