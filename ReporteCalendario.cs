using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones {
    public partial class ReporteCalendario : Form {
        public ReporteCalendario() {
            InitializeComponent();
        }

        private void ReporteCalendario_Load(object sender, EventArgs e) {

            ConfigurarCalendario();
            this.reportViewer1.RefreshReport();
        }
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

            // Rellenar el DataGridView con los días del mes actual
            DateTime primerDiaDelMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int diaInicio = (int)primerDiaDelMes.DayOfWeek;
            int diasEnMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            int fila = 0, columna = diaInicio;
            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                dataGridView1[columna, fila].Value = dia;

                DateTime fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia);
                //if (eventos.ContainsKey(fecha))
                //{
                //    dataGridView1[columna, fila].Style.BackColor = Color.Yellow;
                //}

                columna++;
                if (columna == 7)
                {
                    columna = 0;
                    fila++;
                }
            }

            //dataGridView1.CellClick += DataGridView1_CellClick;
        }
    }
}
