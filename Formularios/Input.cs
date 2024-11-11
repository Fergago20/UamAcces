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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login1 = new Form1();
            login1.ShowDialog();
        }
    }
}
