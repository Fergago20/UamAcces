using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.Dao;
using UamAcces.Formularios;
using UamAcces.models;

namespace UamAcces.Forms
{
    public partial class FrmReport2 : MaterialForm
    {
        List<Entrant> entrants;
        Administration administration= new Administration();
        public FrmReport2()
        {
            administration.ReadFile();
            InitializeComponent();
            Options();
            entrants= administration.GetUsers();
            CbRole.SelectedItem = "Todos";
        }

        private void Options()
        {
            CbRole.Items.Clear();
            string contenido2 = Properties.Resources.Roles;

            string[] roles = contenido2.Split(new[]
            { Environment.NewLine }, StringSplitOptions.None);
            CbRole.Items.AddRange(roles);
            CbRole.Items.Add("Todos");
        }

        private void btmInforme_Click(object sender, EventArgs e)
        {
            List<Entrant> entrants2 = new List<Entrant>();
            string role= CbRole.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(role))
            {

                ReportAdmin reportAdmin = new ReportAdmin();
                entrants2 = reportAdmin.Organize2(entrants, role);
                reportAdmin.BubbleSort(entrants2);
                Report(entrants2);
            }
            else
            {
                MessageBox.Show("Seleccione un rol", "No hay datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Report(List<Entrant> origin)
        {
            ReportDataSource dataSource = new ReportDataSource("DtEntrant", origin);
            FrmFinalReport finalReport = new FrmFinalReport();
            finalReport.reportViewer1.LocalReport.DataSources.Clear();
            finalReport.reportViewer1.LocalReport.DataSources.Add(dataSource);
            finalReport.reportViewer1.LocalReport.ReportEmbeddedResource =
                "UamAcces.Reports.RptEntrant.rdlc";
            finalReport.reportViewer1.RefreshReport();

            finalReport.ShowDialog();
        }

        private void BtmReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Salir?", "Salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdministratorUi admin = new AdministratorUi();
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
        }
    }
}
