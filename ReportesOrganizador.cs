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
    public partial class ReportesOrganizador : Form {
        ClsReportes objReportes = new ClsReportes();
        public ReportesOrganizador() {
            InitializeComponent();
        }

        private void ReportesOrganizador_Load(object sender, EventArgs e) {

            this.reportViewer1.RefreshReport();
        }

        private void txtBoxNombreEvento_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método para obtener los datos
            DataTable tablaEventos = objReportes.ListarOrganizadorEventosAntiguos("%"+txtBoxNombreEvento.Text+"%");

            // Configurar el ReportViewer
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"Reportes\ReporteOrganizadoresEventoAntiguos.rdlc";

            // Limpia las fuentes de datos del informe
            reportViewer1.LocalReport.DataSources.Clear();

            // Configura la fuente de datos del informe
            ReportDataSource rds = new ReportDataSource("DataSetOrganizadoresEventos", tablaEventos);
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refrescar el ReportViewer
            this.reportViewer1.RefreshReport();
        }
    }
}
