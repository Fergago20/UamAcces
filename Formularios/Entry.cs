using MaterialSkin;
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
            lblHora.Text = "Hora: ";
            lblHora.Text += DateTime.Now.ToString("hh:mm:ss tt");
            lblDia.Text = $"Día {DateTime.Today.ToString("dd/MM/yyyy")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.FromArgb(55, 71, 79), 5))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, 
                    this.Width - 1, this.Height - 1);
            }
        }
    }
}
