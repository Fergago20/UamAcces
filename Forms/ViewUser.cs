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
    public partial class ViewUser : MaterialForm
    {
        List<User> users = new List<User>();
        Filter filter = new Filter();
        AdministrationUser administrationUser = new AdministrationUser();
        public ViewUser()
        {
            InitializeComponent();
            administrationUser.ReadFile();
            users= administrationUser.GetUsers();
            Options();
            CbFaculty.SelectedItem = "Todos";
            CbRole.SelectedItem = "Todos";
        }

        private void Options()
        {
            CbFaculty.Items.Clear();
            CbRole.Items.Clear();
           
            string contenido2 = Properties.Resources.Roles;
            string contenido1 = Properties.Resources.Facultades;

            string[] roles = contenido2.Split(new[]
            { Environment.NewLine }, StringSplitOptions.None);
            CbRole.Items.AddRange(roles);
            CbRole.Items.Add("Todos");

            string[] faculties = contenido1.Split(new[]
            { Environment.NewLine }, StringSplitOptions.None);
            CbFaculty.Items.AddRange(faculties);
            CbFaculty.Items.Add("Todos");
        }

        public void ShowData(string faculty, string role)
        {

            DgvUser.DataSource = null;
            DgvUser.DataSource = filter.FilterData(users, faculty,role);

        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFaculty.SelectedItem != null && CbRole.SelectedItem != null)
            {
                ShowData(CbFaculty.SelectedItem.ToString(), CbRole.SelectedItem.ToString());
            }
        }

        private void CbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFaculty.SelectedItem != null && CbRole.SelectedItem != null)
            {
                ShowData(CbFaculty.SelectedItem.ToString(), CbRole.SelectedItem.ToString());
            }
        }

        private void btmInforme_Click(object sender, EventArgs e)
        {
            string faculty = CbFaculty.SelectedItem.ToString();
            string role = CbRole.SelectedItem.ToString();
            Report(filter.FilterData(users, faculty, role));
        }

        private void Report(List<User> origin)
        {
            ReportDataSource dataSource = new ReportDataSource("DsAllUser", origin);
            FrmFinalReport finalReport = new FrmFinalReport();
            finalReport.reportViewer1.Reset();
            finalReport.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            finalReport.reportViewer1.LocalReport.DataSources.Clear();
            finalReport.reportViewer1.LocalReport.DataSources.Add(dataSource);
            finalReport.reportViewer1.LocalReport.ReportEmbeddedResource =
                "UamAcces.Reports.RptAllUser.rdlc";
            finalReport.reportViewer1.RefreshReport();

            finalReport.ShowDialog();
        }
    }
}
