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
    public partial class Exit : MaterialForm
    {
        Administration administration = new Administration();
        Entrant entrant;
        TimeSpan timeElapsed;
      
        public Exit(Entrant user)
        {
            InitializeComponent();
            entrant = user;
            administration.ReadFile();
            
            
            if (entrant != null)
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (entrant != null)
            {
                
                timeElapsed = DateTime.Now - entrant.Entry;

                
                LblHour.Text = $"Hora Actual: {DateTime.Now:hh:mm:ss tt}";
                LblRestHour.Text = $"Horas Transcurridas: {timeElapsed:hh\\:mm\\:ss}";
                LblEntry.Text= $"Hora de Entrada: {entrant.Entry}.";
            }
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            if (entrant != null)
            {
                administration.Update(entrant.CIF, DateTime.Now, timeElapsed);
                MessageBox.Show("Salida registrada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
