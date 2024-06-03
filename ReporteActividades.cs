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
    public partial class ReporteActividades : Form {
        ClsReportes objReportes = new ClsReportes();
        public ReporteActividades() {
            InitializeComponent();
        }

        private void ReporteActividades_Load(object sender, EventArgs e) {
            //Llenar Combobox con Fechas Disponibles
            ListarFechasDisponibles();

        }
        private void ListarFechasDisponibles()
        {
            ClsReportes objReportes = new ClsReportes();
            comboBoxFechas.DataSource = objReportes.ListarFechasDisponibles();
            comboBoxFechas.DisplayMember = "FechaReserva";
            comboBoxFechas.ValueMember = "IdEvento";

        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            // Llamar al método para obtener los datos
            DataTable tablaActividades = objReportes.ListarEventosYEspacioes(Convert.ToInt32(comboBoxFechas.SelectedValue));

            // Configurar el ReportViewer
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"Reportes\ReporteActividades.rdlc";

            // Limpia las fuentes de datos del informe
            reportViewer1.LocalReport.DataSources.Clear();

            // Configura la fuente de datos del informe
            ReportDataSource rds = new ReportDataSource("DataSetActividades", tablaActividades);
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refrescar el ReportViewer
            this.reportViewer1.RefreshReport();
        }
    }
}
