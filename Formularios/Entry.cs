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
    public partial class Entry : MaterialForm
    {
        public Entry()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text += DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
