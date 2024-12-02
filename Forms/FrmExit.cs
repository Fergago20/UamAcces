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
                Input input = new Input();
                this.Hide();
                input.ShowDialog();
                this.Close();
            }
        }

        private void BtmClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salida", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Input input = new Input();
                input.ShowDialog();
                this.Close();
            }
            
        }
    }
}
