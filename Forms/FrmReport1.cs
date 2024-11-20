﻿using MaterialSkin.Controls;
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
        public Report1()
        {
            InitializeComponent();
            administration.ReadFile();
            entrants= administration.GetUsers();
            Options();
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
                DateTime date1 = DtpDate1.Value;
                DateTime date2 = DtpDate2.Value;
                string role = CbRole.SelectedItem.ToString();
                if (date1 < date2 && !string.IsNullOrEmpty(role))
                {
                    if (role == "Todos")
                    {
                        Report(entrants);
                    }
                    else
                    {
                        ReportAdmin reportAdmin = new ReportAdmin();
                        entrants=reportAdmin.Organize(entrants, date1, date2, role);
                        Report(entrants);
                    }
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