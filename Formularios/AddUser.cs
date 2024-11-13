using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.models;

namespace UamAcces.Formularios
{
    public partial class AddUser : MaterialForm
    {
        Administration administration = new Administration(); 
        public AddUser()
        {
            InitializeComponent();
            Option();
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

        private void Option()
        {
            CbFaculty.Items.Clear();
            CbRole.Items.Clear();
            string contenido1 = Properties.Resources.Facultades;
            string contenido2= Properties.Resources.Roles;

            // Dividir el contenido en líneas
            string[] faculties = contenido1.Split(new[] 
            { Environment.NewLine }, StringSplitOptions.None);
            CbFaculty.Items.AddRange(faculties);

            string[] roles = contenido2.Split(new[]
            { Environment.NewLine }, StringSplitOptions.None);
            CbRole.Items.AddRange(roles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.CIF = int.Parse(TbCif.Text);
            user.Password = int.Parse(TbPassword.Text);
            user.
        }
    }
}
