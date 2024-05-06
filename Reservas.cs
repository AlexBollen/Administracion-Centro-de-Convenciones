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
        int UpdatePersonaId, UpdateResponsableId, UpdateItinerarioId;
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
                // Control de visualización de componentes
                listReservations.Hide();
                addReservation.Show();
                btnRegistrar.Hide();
                btnConfirmarEdicion.Show();
                // Cargar tablas relacionadas a combobox
                ListarOrganizadores();
                ListarSalones();
                ListarTiposEvento();
                // Cargar datos del registro a componentes
                IdEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string[] registro;
                registro = objEventos.CargarRegistroEvento(IdEvento);
                txtBoxNombreEvento.Text = registro[1];
                txtBoxDescripcionEvento.Text = registro[2];
                comboBoxEstadoEvento.Text = registro[3];
                txtBoxCantidadAsistentes.Text = registro[4];
                UpdateItinerarioId = Convert.ToInt32(registro[6]);
                UpdateResponsableId = Convert.ToInt32(registro[7]);
                comboBoxOrganizadores.SelectedValue= registro[8];
                comboBoxTipoEvento.SelectedValue = registro[9];
                comboBoxSalon.SelectedValue = registro[10];
                // Cargar datos de itinerario del evento
                string[] itinerario;
                itinerario = objEventos.CargarRegistroItinerario(Convert.ToInt32(registro[6]));
                dateTimePickerFI.Value = Convert.ToDateTime(itinerario[1]);
                dateTimePickerFC.Value = Convert.ToDateTime(itinerario[2]);
                txtBoxHoraInicio.Text = itinerario[3];
                txtBoxHoraCulminacion.Text = itinerario[4];
                // Cargar datos de responsable del evento
                string[] responsable;
                responsable = objEventos.CargarRegistroResponsable(Convert.ToInt32(registro[7]));
                txtBoxNombreComercial.Text = responsable[1];
                UpdatePersonaId = Convert.ToInt32(responsable[2]);
                // Cargar datos de persona 
                string[] persona;
                persona = objEventos.CargarRegistroPersona(Convert.ToInt32(responsable[2]));
                txtBoxNombreCliente.Text = persona[1];


            } else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e) {
            objEventos.EditarReserva(
                IdEvento,
                txtBoxNombreEvento.Text,
                txtBoxDescripcionEvento.Text,
                comboBoxEstadoEvento.Text,
                Convert.ToInt32(txtBoxCantidadAsistentes.Text),
                Convert.ToInt32(comboBoxOrganizadores.SelectedValue),
                Convert.ToInt32(comboBoxTipoEvento.SelectedValue),
                Convert.ToInt32(comboBoxSalon.SelectedValue),
                UpdateItinerarioId,
                dateTimePickerFI.Value,
                dateTimePickerFC.Value,
                txtBoxHoraInicio.Text,
                txtBoxHoraCulminacion.Text,
                UpdateResponsableId,
                txtBoxNombreComercial.Text,
                UpdatePersonaId,
                txtBoxNombreCliente.Text
            );
            btnRegistrar.Show();
            btnConfirmarEdicion.Hide();
            MessageBox.Show("Se ha actualizado el evento correctamente");
            btnListarReservas.PerformClick();

        }

        private void btnEliminarReserva_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el evento?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    objEventos.EliminarReserva(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el evento");
                    ListarEventos();
                }
            } else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }
    }
}
