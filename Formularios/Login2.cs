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
    public partial class Login2 : MaterialForm
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.ShowDialog();
        }
    }
}
