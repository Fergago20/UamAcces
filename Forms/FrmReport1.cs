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
using UamAcces.models;

namespace UamAcces.Formularios
{
    public partial class Report1 : MaterialForm
    {
        Administration administration= new Administration();
        List<Entrant> entrants = new List<Entrant>();
        DateTime limit = DateTime.Now.AddDays(1).Date;
        public Report1()
        {
            InitializeComponent();
            DtpDate1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            DtpDate2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            administration.ReadFile();
            entrants= administration.GetUsers();
            Options();
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
            try
            {
                List<Entrant> entrants1 = new List<Entrant>();
                DateTime date1 = DtpDate1.Value;
                DateTime date2 = DtpDate2.Value;
                string role = CbRole.SelectedItem.ToString();
                if (date1 < date2 && !string.IsNullOrEmpty(role) && date2<limit)
                {
                    
                        ReportAdmin reportAdmin = new ReportAdmin();
                        
                        entrants1=reportAdmin.Organize(entrants, date1, date2, role);
                        Report(entrants1, "DsData", "UamAcces.Reports.RptUsers.rdlc");
                   
                }
                else
                {
                    MessageBox.Show("Llene correctamente los datos", "Error de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error de entradas", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Report(List<Entrant> origin, string type, string path)
        {
            ReportDataSource dataSource = new ReportDataSource(type, origin);
            FrmFinalReport finalReport = new FrmFinalReport();
            finalReport.reportViewer1.LocalReport.DataSources.Clear();
            finalReport.reportViewer1.LocalReport.DataSources.Add(dataSource);
            finalReport.reportViewer1.LocalReport.ReportEmbeddedResource = path;
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

        private void BtmGraphic_Click(object sender, EventArgs e)
        {
            try
            {
               
                DateTime date1 = DtpDate1.Value;
                DateTime date2 = DtpDate2.Value;
                string role = CbRole.SelectedItem.ToString();
                if ((date1 < date2) && (!string.IsNullOrEmpty(role)) && date2< limit)
                {
                    if (role == "Todos")
                    {
                        Report(entrants, "DtGraphic", "UamAcces.Reports.RptGraphic.rdlc");
                    }
                    else
                    {
                        ReportAdmin reportAdmin = new ReportAdmin();
                        List<Entrant> entrants1 = new List<Entrant>();
                        entrants1 = reportAdmin.Organize(entrants, date1, date2, role);
                        Report(entrants1, "DtGraphic", "UamAcces.Reports.RptGraphic.rdlc");
                    }
                }
                else
                {
                    MessageBox.Show("Llene correctamente los datos", "Error de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error de entradas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
