using Administración_Centro_de_Convenciones.Clases;
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
    public partial class Reservas : Form {
        public Reservas() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            listReservations.Hide();
            addReservation.Show();
        }

        private void Reservas_Load(object sender, EventArgs e) {
            listReservations.Show();
            addReservation.Hide();
            ListarEventos();

        }

        private void btnListarReservas_Click(object sender, EventArgs e) {
            listReservations.Show();
            addReservation.Hide();
        }

        private void ListarEventos() {
            ClsEventos objEventos = new ClsEventos();
            dataGridView1.DataSource = objEventos.ListarEventos();
        }
    }
}
