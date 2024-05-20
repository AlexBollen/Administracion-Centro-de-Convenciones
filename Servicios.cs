using Administración_Centro_de_Convenciones.Clases;
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
    public partial class Servicios : Form {
        ClsAsignacionServicios objAsignacionServicios = new ClsAsignacionServicios();
        int IdEvento, IdServicioAsignacion, rowIdServicioAsg;
        string nombreServicio;
        List<Tuple<string, int, int, int>> listaAsignaciones = new List<Tuple<string, int, int, int>>();

        public Servicios() {
            InitializeComponent();
        }

        private void btnListarServicios_Click(object sender, EventArgs e) {
            listAsignaciones.Show();
            listBoxServicios.Items.Clear();
            HideAssingFields();
            btnAgregarServicio.Enabled = true;
            btnEditarAsignacion.Enabled = true;
            btnEliminarAsignacion.Enabled = true;
            ListarAsignaciones();
        }

        private void ListarAsignaciones() {
            ClsAsignacionServicios objListAsignaciones = new ClsAsignacionServicios();
            dataGridViewServicios.DataSource = objListAsignaciones.ListarServicios();
        }

        private void Servicios_Load(object sender, EventArgs e) {
            HideAssingFields();
            ListarAsignaciones();
        }

        private void ListarExistenciasServicios(DateTime date) {
            ClsAsignacionServicios objListExistencias = new ClsAsignacionServicios();
            dataGridViewAsignacion.DataSource = objListExistencias.ListarExistenciasServicios(date);
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e) {
            if (dataGridViewServicios.SelectedRows.Count > 0) {
                // Manejar visualización de componentes
                ShowAssingFields();
                // Cargar datos del registro a componentes
                IdEvento = Convert.ToInt32(dataGridViewServicios.CurrentRow.Cells[0].Value);
                // Obtener fecha del evento
                DateTime fecha = objAsignacionServicios.ObtenerFechaEvento(IdEvento);
                // Cargar tablas relacionadas a datagridview
                ListarExistenciasServicios(fecha);
            } else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void ShowAssingFields() {
            dataGridViewServicios.Hide();
            dataGridViewAsignacion.Show();
            txtBoxDetalle.Show();
            txtBoxDetalle.Enabled = false;
            txtBoxCantidad.Show();
            txtBoxCantidad.Enabled = false;
            btnReservarServicio.Show();
            btnReservarServicio.Enabled = false;
            btnFinalizarAsignacion.Show();
            btnFinalizarAsignacion.Enabled = false;
            listBoxServicios.Height = 165;
            label4.Show();
            label5.Show();
            
        }

        private void HideAssingFields() {
            dataGridViewServicios.Show();
            dataGridViewAsignacion.Hide();
            txtBoxDetalle.Hide();
            txtBoxDetalle.Enabled = false;
            txtBoxCantidad.Hide();
            txtBoxCantidad.Enabled = false;
            btnReservarServicio.Hide();
            btnReservarServicio.Enabled = false;
            btnFinalizarAsignacion.Hide();
            btnFinalizarAsignacion.Enabled = false;
            pbValidation1.Hide();
            pbValidation2.Hide();
            listBoxServicios.Height = 340;
            label4.Hide();
            label5.Hide();
            
        }

        private void dataGridViewServicios_MouseClick(object sender, MouseEventArgs e) {
        }

        private void ListarServiciosEvento(int IdEvento) {
            ClsAsignacionServicios objListServiciosEv = new ClsAsignacionServicios();
            DataTable table = objListServiciosEv.ListarServiciosEvento(IdEvento);
            foreach (DataRow row in table.Rows) {
                string item = $"{row["NombreServicio"]} - {row["Cantidad"]}";
                listBoxServicios.Items.Add(item);
            }
            table.Rows.Clear();
        }

        private void dataGridViewServicios_SelectionChanged(object sender, EventArgs e) {
            if (dataGridViewServicios.SelectedRows.Count > 0) {
                listBoxServicios.Items.Clear();
                int idEv = Convert.ToInt32(dataGridViewServicios.CurrentRow.Cells[0].Value);
                ListarServiciosEvento(idEv);
            }
        }

        private void btnReservarServicio_Click(object sender, EventArgs e) {
            if (FieldsValidation()) {
                string listItem = $"{nombreServicio} - {txtBoxCantidad.Text}";
                int valorActual = Convert.ToInt32(dataGridViewAsignacion.Rows[rowIdServicioAsg].Cells[2].Value);
                int valorResta = Convert.ToInt32(txtBoxCantidad.Text);
                if (valorResta > valorActual)
                    MessageBox.Show("No se puede asignar mas que las existencias actuales");
                else {
                    listaAsignaciones.Add(Tuple.Create(txtBoxDetalle.Text,
                        valorResta,
                        IdEvento,
                        IdServicioAsignacion));
                    listBoxServicios.Items.Add(listItem);
                    txtBoxCantidad.Clear();
                    txtBoxCantidad.Enabled = false;
                    txtBoxDetalle.Clear();
                    txtBoxDetalle.Enabled = false;
                    btnFinalizarAsignacion.Enabled = true;
                }
            } else
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");
        }

        private void dataGridViewAsignacion_SelectionChanged(object sender, EventArgs e) {
            if (dataGridViewAsignacion.SelectedRows.Count > 0) {
                // Limpiar campos
                txtBoxDetalle.Clear();
                txtBoxDetalle.Enabled = true;
                txtBoxCantidad.Clear();
                txtBoxCantidad.Enabled = true;
                btnReservarServicio.Enabled = true;
                IdServicioAsignacion = Convert.ToInt32(dataGridViewAsignacion.CurrentRow.Cells[0].Value);
                rowIdServicioAsg = dataGridViewAsignacion.SelectedRows[0].Index;
                nombreServicio = dataGridViewAsignacion.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnFinalizarAsignacion_Click(object sender, EventArgs e) {
            foreach (var elemento in listaAsignaciones) {
                objAsignacionServicios.InsertarAsignacionServicio(
                    elemento.Item1,
                    elemento.Item2,
                    elemento.Item3,
                    elemento.Item4);
            }
            objAsignacionServicios.ActualizarEstadoAsignacion(IdEvento, 1);
            MessageBox.Show("Se asignaron correctamente los servicios al evento");
            btnListarServicios.PerformClick();
        }

        private void btnEliminarAsignacion_Click(object sender, EventArgs e) {
            if (dataGridViewServicios.SelectedRows.Count > 0) {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar los servicios asignados al evento?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    objAsignacionServicios.EliminarAsignaciones(Convert.ToInt32(dataGridViewServicios.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se han eliminado correctamente las asignaciones de servicios");
                    objAsignacionServicios.ActualizarEstadoAsignacion(IdEvento, 0);
                    btnListarServicios.PerformClick();
                }
            } else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private bool FieldsValidation() {
            int sum = 0;
            Regex detailValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,100}$");
            Regex quantityValidation = new Regex(@"^[0-9]{1,8}$");
            if (!detailValidation.IsMatch(txtBoxDetalle.Text)) {
                pbValidation1.Show();
            } else {
                pbValidation1.Hide();
                sum += 1;
            }
            if (!quantityValidation.IsMatch(txtBoxCantidad.Text)) {
                pbValidation2.Show();
            } else {
                pbValidation2.Hide();
                sum += 1;
            }
            if (sum == 2)
                return true;
            else
                return false;
        }
    }
}
