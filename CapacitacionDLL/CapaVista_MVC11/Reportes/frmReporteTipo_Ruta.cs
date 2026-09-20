using CapaModelo_MVC1.Entidades;
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
using CapaControlador_MVC1;
using CapaControlador_MVC1.Modelos_de_controladores;

namespace CapaVista_MVC11.Reportes
{
    public partial class frmReporteTipo_Ruta : Form
    {
        private ModeloTipo_Ruta tipo_Ruta = new ModeloTipo_Ruta();

        public frmReporteTipo_Ruta()
        {
            InitializeComponent();
        }

        private void frmReporteTipo_Ruta_Load(object sender, EventArgs e)
        {

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", tipo_Ruta.GetAll());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_MVC11.Reportes.ReporteTipo_Ruta.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
