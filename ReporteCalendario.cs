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


namespace Administración_Centro_de_Convenciones {
    public partial class ReporteCalendario : Form {
        private Dictionary<DateTime, string> eventos;
        private DateTime fechaActual;

        public ReporteCalendario() {
            InitializeComponent();
            eventos = new Dictionary<DateTime, string>();
            fechaActual = DateTime.Now;

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

        //private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        var cellValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
        //        if (cellValue != null && int.TryParse(cellValue.ToString(), out int dia))
        //        {
        //            DateTime fecha = new DateTime(fechaActual.Year, fechaActual.Month, dia);
        //            if (eventos.ContainsKey(fecha))
        //            {
        //                MessageBox.Show(eventos[fecha], "Información del Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //}

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

        //dataGridView1.CellClick += DataGridView1_CellClick;
        /*private void CargarEventosDesdeBaseDeDatos()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["EventosDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Fecha, Descripcion FROM Eventos";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime fecha = reader.GetDateTime(0);
                    string descripcion = reader.GetString(1);
                    eventos[fecha] = descripcion;
                }
            }
        }*/
    }
}
