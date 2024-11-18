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
            string role= CbRole.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(role))
            {
                ReportAdmin reportAdmin = new ReportAdmin();
                entrants=reportAdmin.Organize2(entrants, role);
                Report(entrants);
            }
        }

        private void Report(List<Entrant> origin)
        {
            ReportDataSource dataSource = new ReportDataSource("DsData", origin);
            FrmFinalReport finalReport = new FrmFinalReport();
            finalReport.reportViewer1.LocalReport.DataSources.Clear();
            finalReport.reportViewer1.LocalReport.DataSources.Add(dataSource);
            finalReport.reportViewer1.LocalReport.ReportEmbeddedResource =
                "UamAcces.Reports.RptUsers.rdlc";
            finalReport.reportViewer1.RefreshReport();

            finalReport.ShowDialog();
        }
    }
}
