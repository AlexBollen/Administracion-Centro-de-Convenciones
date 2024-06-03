using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using Administración_Centro_de_Convenciones.Clases;
using Microsoft.Reporting.WinForms;

namespace Administración_Centro_de_Convenciones {
    public partial class ReporteCalendario : Form {
        ClsReportes objReportes = new ClsReportes();
        private Dictionary<DateTime, int> eventos;
        private DateTime fechaActual;

        public ReporteCalendario() {
            InitializeComponent();
            eventos = new Dictionary<DateTime, int>();
            fechaActual = DateTime.Now;

            eventos = objReportes.CargarEventosDesdeBaseDeDatos();
            // Cargar eventos desde la base de datos
            //CargarEventosDesdeBaseDeDatos();

            // Configurar el DataGridView como calendario
            ConfigurarCalendario();
            ActualizarCalendario();
        }

        private void ReporteCalendario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        //private void CargarEventosDesdeBaseDeDatos()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["EventosDB"].ConnectionString;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT Fecha, Descripcion FROM Eventos";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            DateTime fecha = reader.GetDateTime(0);
        //            string descripcion = reader.GetString(1);
        //            eventos[fecha] = descripcion;
        //        }
        //    }
        //}

        private void ConfigurarCalendario()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = 6;

            // Asignar nombres a las columnas (días de la semana)
            string[] dias = { "Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb" };
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].Name = dias[i];
                dataGridView1.Columns[i].Width = 40;
            }

            //dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void ActualizarCalendario()
        {
            // Limpiar el DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                    cell.Style.BackColor = Color.White;
                }
            }

            // Actualizar etiqueta de mes y año
            labelMesAno.Text = fechaActual.ToString("MMMM yyyy");

            // Rellenar el DataGridView con los días del mes actual
            DateTime primerDiaDelMes = new DateTime(fechaActual.Year, fechaActual.Month, 1);
            int diaInicio = (int)primerDiaDelMes.DayOfWeek;
            int diasEnMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);

            int fila = 0, columna = diaInicio;
            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                // Asegurarse de que los índices de fila y columna estén dentro de los límites
                if (fila < dataGridView1.RowCount && columna < dataGridView1.ColumnCount)
                {
                    dataGridView1[columna, fila].Value = dia;

                    DateTime fecha = new DateTime(fechaActual.Year, fechaActual.Month, dia);
                    if (eventos.ContainsKey(fecha))
                    {
                        dataGridView1[columna, fila].Style.BackColor = Color.Yellow;
                    }

                    columna++;
                    if (columna == 7)
                    {
                        columna = 0;
                        fila++;
                    }
                }
            }
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(-1);
            ActualizarCalendario();
        }

        private void btnMesSiguiente_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(1);
            ActualizarCalendario();
        }

        private void btnAnoAnterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddYears(-1);
            ActualizarCalendario();
        }

        private void btnAnoSiguiente_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddYears(1);
            ActualizarCalendario();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int dia))
                {
                    DateTime fecha = new DateTime(fechaActual.Year, fechaActual.Month, dia);
                    if (eventos.ContainsKey(fecha))
                    {
                        // Llamar al método para obtener los datos
                        DataTable tablaActividades = objReportes.ListarEventosYEspacioes(eventos[fecha]);

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
        }


    }
}
