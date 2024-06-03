using Administración_Centro_de_Convenciones.Clases;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones {
    public partial class Reservas : Form {
        ClsEventos objEventos = new ClsEventos();
        int UpdatePersonaId, UpdateResponsableId, UpdateItinerarioId, UpdateOrganizadorId;
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
            btnConfirmarEdicion.Hide();
            btnRegistrar.Show();
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
            if (FieldsValidation()) {
                if (VerificarCapacidadSalon(
                        Convert.ToInt32(txtBoxCantidadAsistentes.Text),
                        Convert.ToInt32(comboBoxSalon.SelectedValue))
                    &&
                    VerificarEstadoOrganizador(
                        Convert.ToInt32(comboBoxOrganizadores.SelectedValue))
                    ) {
                    DateTime now = DateTime.Now;
                    int idItinerario = objEventos.InsertarItinerario(
                        dateTimePickerFI.Value,
                        txtBoxHoraInicio.Text,
                        txtBoxHoraCulminacion.Text);
                    int idPersona = objEventos.InsertarPersona(
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
                    objEventos.EditarEstadoOrganizadorOcupado(Convert.ToInt32(comboBoxOrganizadores.SelectedValue));
                    ClearData();
                    btnListarReservas.PerformClick();
                }
            } else {
                MessageBox.Show("Campos invalidos. Por favor verifique!");
            }
        }

        private void ClearData() {
            txtBoxCantidadAsistentes.Clear();
            txtBoxNombreEvento.Clear();
            txtBoxDescripcionEvento.Clear();
            txtBoxHoraInicio.Clear();
            txtBoxHoraCulminacion.Clear();
            txtBoxNombreCliente.Clear();
            txtBoxNombreComercial.Clear();
            pbValidation1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                ClearData();
                // Control de visualización de componentes
                listReservations.Hide();
                addReservation.Show();
                btnRegistrar.Hide();
                btnConfirmarEdicion.Show();
                btnEliminarReserva.Enabled = false;
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
                UpdateItinerarioId = Convert.ToInt32(registro[7]);
                UpdateResponsableId = Convert.ToInt32(registro[8]);
                comboBoxOrganizadores.SelectedValue= registro[9];
                UpdateOrganizadorId = Convert.ToInt32(registro[9]);
                comboBoxTipoEvento.SelectedValue = registro[10];
                comboBoxSalon.SelectedValue = registro[11];
                // Cargar datos de itinerario del evento
                string[] itinerario;
                itinerario = objEventos.CargarRegistroItinerario(Convert.ToInt32(registro[7]));
                dateTimePickerFI.Value = Convert.ToDateTime(itinerario[1]);
                txtBoxHoraInicio.Text = itinerario[2];
                txtBoxHoraCulminacion.Text = itinerario[3];
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
            if (FieldsValidation()) {
                if (VerificarCapacidadSalon(
                        Convert.ToInt32(txtBoxCantidadAsistentes.Text),
                        Convert.ToInt32(comboBoxSalon.SelectedValue))
                    &&
                    VerificarEstadoOrganizador(
                        Convert.ToInt32(comboBoxOrganizadores.SelectedValue))
                    ) {
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
                        txtBoxHoraInicio.Text,
                        txtBoxHoraCulminacion.Text,
                        UpdateResponsableId,
                        txtBoxNombreComercial.Text,
                        UpdatePersonaId,
                        txtBoxNombreCliente.Text
                    );
                    if (comboBoxEstadoEvento.Text == "Finalizado") {
                        objEventos.EditarEstadoOrganizador(Convert.ToInt32(comboBoxOrganizadores.SelectedValue));
                    }
                    btnRegistrar.Show();
                    btnConfirmarEdicion.Hide();
                    MessageBox.Show("Se ha actualizado el evento correctamente");
                    btnListarReservas.PerformClick();
                }
            } else {
                MessageBox.Show("Campos invalidos. Por favor verifique!");
            }

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

        private void comboBoxEstadoEvento_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private bool VerificarCapacidadSalon(int Asistentes, int IdSalon) {
            string[] registro;
            registro = objEventos.CargarCapacidadSalon(IdSalon);
            int capacidad = Convert.ToInt32(registro[0]);
            if (Asistentes > capacidad) {
                MessageBox.Show("La cantidad de asistentes supera la capacidad del salón");
                return false;
            } else {
                return true;
            }
        }

        private bool VerificarEstadoOrganizador(int IdOrganizador) {
            if (IdOrganizador != UpdateOrganizadorId) {
                string[] registro;
                registro = objEventos.CargarEstadoOrganizador(IdOrganizador);
                string estado = registro[0].ToString();
                if (estado == "No Disponible") {
                    MessageBox.Show("El organizador seleccionado no se encuentra disponible actualmente");
                    return false;
                } else {
                    return true;
                }
            } else {
                return true;
            }
        }

        private bool FieldsValidation() {
            int sum = 0;
            Regex nameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,100}$");
            Regex descriptionValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,150}$");
            Regex eventStateValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,75}$");
            Regex eventTypeValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,75}$");
            Regex organicerValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,100}$");
            Regex customerNameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,100}$");
            Regex roomValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,100}$");
            Regex comertialNameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s.]{1,100}$");
            Regex assistentsValidation = new Regex(@"^[0-9]{1,8}$");
            Regex startHourValidation = new Regex(@"^([01]?[0-9]|2[0-3]):[0-5][0-9]$");
            Regex endHourValidation = new Regex(@"^([01]?[0-9]|2[0-3]):[0-5][0-9]$");
            if (!nameValidation.IsMatch(txtBoxNombreEvento.Text)) {
                pbValidation1.Show();
            } else {
                pbValidation1.Hide();
                sum += 1;
            }
            if (!descriptionValidation.IsMatch(txtBoxDescripcionEvento.Text)) {
                pictureBox1.Show();
            } else {
                pictureBox1.Hide();
                sum += 1;
            }
            if (!eventTypeValidation.IsMatch(comboBoxTipoEvento.Text)) {
                pictureBox2.Show();
            } else {
                pictureBox2.Hide();
                sum += 1;
            }
            if (!organicerValidation.IsMatch(comboBoxOrganizadores.Text)) {
                pictureBox3.Show();
            } else {
                pictureBox3.Hide();
                sum += 1;
            }
            if (!customerNameValidation.IsMatch(txtBoxNombreCliente.Text)) {
                pictureBox4.Show();
            } else {
                pictureBox4.Hide();
                sum += 1;
            }
            if (!roomValidation.IsMatch(comboBoxSalon.Text)) {
                pictureBox5.Show();
            } else {
                pictureBox5.Hide();
                sum += 1;
            }
            if (!comertialNameValidation.IsMatch(txtBoxNombreComercial.Text)) {
                pictureBox6.Show();
            } else {
                pictureBox6.Hide();
                sum += 1;
            }
            if (!assistentsValidation.IsMatch(txtBoxCantidadAsistentes.Text)) {
                pictureBox7.Show();
            } else {
                pictureBox7.Hide();
                sum += 1;
            }
            if (!startHourValidation.IsMatch(txtBoxHoraInicio.Text)) {
                pictureBox8.Show();
            } else {
                pictureBox8.Hide();
                sum += 1;
            }
            if (!endHourValidation.IsMatch(txtBoxHoraCulminacion.Text)) {
                pictureBox9.Show();
            } else {
                pictureBox9.Hide();
                sum += 1;
            }
            if (!eventStateValidation.IsMatch(comboBoxEstadoEvento.Text)) {
                pictureBox10.Show();
            } else {
                pictureBox10.Hide();
                sum += 1;
            }
            if (sum == 11)
                return true;
            else
                return false;
        }
    }
}
