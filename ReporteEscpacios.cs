using Administración_Centro_de_Convenciones.Clases;
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

namespace Administración_Centro_de_Convenciones {
    public partial class ReporteEscpacios : Form {
        ClsReportes objReportes = new ClsReportes();
        public ReporteEscpacios() {
            InitializeComponent();
        }

        private void ReporteEscpacios_Load(object sender, EventArgs e) {
            // Llamar al método para obtener los datos
            DataTable tablaCantidadEspacios = objReportes.ListarCantidadEspacios();

            // Configurar el ReportViewer
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"Reportes\ReporteEspacios.rdlc";

            // Limpia las fuentes de datos del informe
            reportViewer1.LocalReport.DataSources.Clear();

            // Configura la fuente de datos del informe
            ReportDataSource rds = new ReportDataSource("DataSetReporteEspacios", tablaCantidadEspacios);
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refrescar el ReportViewer
            this.reportViewer1.RefreshReport();
        }
    }
}
