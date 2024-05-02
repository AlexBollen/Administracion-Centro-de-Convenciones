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
        ClsEventos objEventos = new ClsEventos();
        public Reservas() {
            InitializeComponent();
        }
        int IdEvento;
        private void button1_Click(object sender, EventArgs e) {
            listReservations.Hide();
            addReservation.Show();
            btnAgregarReserva.Enabled = false;
            btnEditarReserva.Enabled = false;
            btnEliminarReserva.Enabled = false;
            ClearData();
            ListarSalones();
            ListarOrganizadores();
            ListarTiposEvento();
        }

        private void Reservas_Load(object sender, EventArgs e) {
            listReservations.Show();
            addReservation.Hide();
            btnAgregarReserva.Enabled = true;
            btnEditarReserva.Enabled = true;
            btnEliminarReserva.Enabled = true;
            btnConfirmarEdicion.Hide();
            ListarEventos();

        }

        private void btnListarReservas_Click(object sender, EventArgs e) {
            listReservations.Show();
            addReservation.Hide();
            btnAgregarReserva.Enabled = true;
            btnEditarReserva.Enabled = true;
            btnEliminarReserva.Enabled = true;
            ListarEventos();
        }

        private void ListarEventos() {
            ClsEventos objListEventos = new ClsEventos();
            dataGridView1.DataSource = objListEventos.ListarEventos();
        }

        private void ListarSalones() {
            ClsEventos objSalones = new ClsEventos();
            comboBoxSalon.DataSource = objSalones.ListarSalones();
            comboBoxSalon.DisplayMember = "NombreSalon";
            comboBoxSalon.ValueMember = "IdSalon";
        }

        private void ListarOrganizadores() {
            ClsEventos objOrganizadores = new ClsEventos();
            comboBoxOrganizadores.DataSource = objOrganizadores.ListarOrganizadores();
            comboBoxOrganizadores.DisplayMember = "NombreOrganizador";
            comboBoxOrganizadores.ValueMember = "IdOrganizador";
        }

        private void ListarTiposEvento() {
            ClsEventos objListTE = new ClsEventos();
            comboBoxTipoEvento.DataSource = objListTE.ListarTiposEvento();
            comboBoxTipoEvento.DisplayMember = "NombreTipoEvento";
            comboBoxTipoEvento.ValueMember = "IdTipoEvento";
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            int idItinerario = objEventos.InsertarItinerario(
                dateTimePickerFI.Value, 
                dateTimePickerFC.Value, 
                txtBoxHoraInicio.Text, 
                txtBoxHoraCulminacion.Text);
            int idPersona= objEventos.InsertarPersona(
                txtBoxNombreCliente.Text);
            int idResponsable = objEventos.InsertarResponsable(
                txtBoxNombreComercial.Text,
                idPersona);
            objEventos.InsertarReserva(
                txtBoxNombreEvento.Text, 
                txtBoxDescripcionEvento.Text,
                "Programado",
                Convert.ToInt32(txtBoxCantidadAsistentes.Text),
                Convert.ToDateTime(now),
                idItinerario,
                idResponsable,
                Convert.ToInt32(comboBoxOrganizadores.SelectedValue),
                Convert.ToInt32(comboBoxTipoEvento.SelectedValue),
                Convert.ToInt32(comboBoxSalon.SelectedValue)
            );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnListarReservas.PerformClick();
        }

        private void ClearData() {
            txtBoxCantidadAsistentes.Clear();
            txtBoxNombreEvento.Clear();
            txtBoxDescripcionEvento.Clear();
            txtBoxHoraInicio.Clear();
            txtBoxHoraCulminacion.Clear();
            txtBoxNombreCliente.Clear();
            txtBoxNombreComercial.Clear();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                listReservations.Hide();
                addReservation.Show();
                btnRegistrar.Hide();
                btnConfirmarEdicion.Show();
                ListarOrganizadores();
                ListarSalones();
                ListarTiposEvento();
                IdEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtBoxNombreEvento.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtBoxDescripcionEvento.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBoxEstadoEvento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtBoxCantidadAsistentes.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBoxOrganizadores.Enabled = true;
                comboBoxOrganizadores.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBoxOrganizadores.Enabled = false;
                txtBoxNombreCliente.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                comboBoxSalon.Enabled = true;
                comboBoxSalon.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                comboBoxSalon.Enabled = false;
                comboBoxTipoEvento.Enabled = true;
                comboBoxTipoEvento.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                comboBoxTipoEvento.Enabled = false;
            } else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e) {
            objEventos.EditarReserva(
                IdEvento,
                txtBoxNombreEvento.Text,
                txtBoxDescripcionEvento.Text,
                comboBoxEstadoEvento.Text,
                Convert.ToInt32(txtBoxCantidadAsistentes.SelectedText),
                Convert.ToInt32(comboBoxOrganizadores.SelectedValue),
                Convert.ToInt32(comboBoxTipoEvento.SelectedValue),
                Convert.ToInt32(comboBoxSalon.SelectedValue)
            );
            btnRegistrar.Show();
            btnConfirmarEdicion.Hide();
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e) {

        }
    }
}
