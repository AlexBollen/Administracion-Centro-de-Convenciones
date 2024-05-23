using Administración_Centro_de_Convenciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones {
    public partial class Servicios : Form {
        ClsAsignacionServicios objAsignacionServicios = new ClsAsignacionServicios();
        int IdEvento, IdServicioAsignacion, rowIdServicioAsg;
        bool editMode = false;
        bool inList = false;
        string nombreServicio;
        List<Tuple<string, int, int, int>> listaAsignaciones = new List<Tuple<string, int, int, int>>();

        public Servicios() {
            InitializeComponent();
        }

        private void btnListarServicios_Click(object sender, EventArgs e) {
            editMode = false;
            listAsignaciones.Show();
            listBoxServicios.Items.Clear();
            txtBoxDetalle.Clear();
            txtBoxCantidad.Clear();
            HideAssingFields();
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
                btnEditarAsignacion.Enabled = false;
                btnEliminarAsignacion.Enabled = false;
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
            btnEditResServ.Hide();
            btnEliminarResServ.Hide();
            
        }

        private void dataGridViewServicios_MouseClick(object sender, MouseEventArgs e) {
        }

        private void ListarServiciosEvento(int IdEvento) {
            ClsAsignacionServicios objListServiciosEv = new ClsAsignacionServicios();
            DataTable table = objListServiciosEv.ListarServiciosEvento(IdEvento);
            foreach (DataRow row in table.Rows) {
                string item = $"{row["IdExistencia"]}) {row["NombreServicio"]} - {row["Cantidad"]}";
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
            if (dataGridViewAsignacion.SelectedRows.Count > 0) {
                if (FieldsValidation()) {
                    string listItem = $"{IdServicioAsignacion}) {nombreServicio} - {txtBoxCantidad.Text}";
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
            } else {
                MessageBox.Show("Debe seleccionar la fila del servicio que desea asignar");
            }
        }

        private bool VerificacionServicioReservado(int IdExistencia) {
            bool verif = false;
            foreach (string item in listBoxServicios.Items) {
                int index = item.IndexOf(')');
                int idExist = Convert.ToInt32(item.Substring(0, index));
                if (idExist == IdExistencia) {
                    verif = true;
                    break;
                }   
            }
            return verif;
        }

        private Tuple<string, int, int, int> VerificarAsignacionLista(int IdExist) {
            Tuple<string, int, int, int>  valueTuple = null;
            foreach (var tuple in listaAsignaciones) {
                if (tuple.Item4 == IdExist) {
                    valueTuple = tuple;
                    break;
                }
            }
            return valueTuple;
        }

        private void dataGridViewAsignacion_SelectionChanged(object sender, EventArgs e) {
            if (dataGridViewAsignacion.SelectedRows.Count > 0) {
                IdServicioAsignacion = Convert.ToInt32(dataGridViewAsignacion.CurrentRow.Cells[0].Value);
                if (!VerificacionServicioReservado(IdServicioAsignacion)) {
                    // Manejo de visualización de componentes
                    btnEditResServ.Hide();
                    btnEliminarResServ.Hide();
                    btnReservarServicio.Show();
                    // Limpiar campos
                    txtBoxDetalle.Clear();
                    txtBoxDetalle.Enabled = true;
                    txtBoxCantidad.Clear();
                    txtBoxCantidad.Enabled = true;
                    btnReservarServicio.Enabled = true;
                    rowIdServicioAsg = dataGridViewAsignacion.SelectedRows[0].Index;
                    nombreServicio = dataGridViewAsignacion.CurrentRow.Cells[1].Value.ToString();
                } else {
                    txtBoxCantidad.Enabled=false;
                    txtBoxDetalle.Enabled=false;
                    btnReservarServicio.Enabled=false;
                    if (editMode)
                        MessageBox.Show("Este servicio ya ha sido asignado\nPor favor edite la asignación existente");
                    else
                        MessageBox.Show("Este servicio ya ha sido asignado");
                }
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
            txtBoxCantidad.Clear();
            txtBoxDetalle.Clear();
            MessageBox.Show("Se asignaron correctamente los servicios al evento");
            btnListarServicios.PerformClick();
        }

        private void btnEditarAsignacion_Click(object sender, EventArgs e) {
            listaAsignaciones.Clear();
            if (dataGridViewServicios.SelectedRows.Count > 0) {
                editMode = true;
                // Manejo de visualización de componentes
                ShowAssingFields();
                btnEliminarAsignacion.Enabled = false;
                // Cargar datos del registro a componentes
                IdEvento = Convert.ToInt32(dataGridViewServicios.CurrentRow.Cells[0].Value);
                // Obtener fecha del evento
                DateTime fecha = objAsignacionServicios.ObtenerFechaEvento(IdEvento);
                // Cargar tablas relacionadas a datagridview
                ListarExistenciasServicios(fecha);
            } else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void listBoxServicios_SelectedIndexChanged(object sender, EventArgs e) {
            if (editMode) {
                if (listBoxServicios.SelectedIndex != -1) {
                    txtBoxCantidad.Enabled = true;
                    txtBoxDetalle.Enabled= true;
                    btnEditResServ.Show();
                    btnEliminarResServ.Show();
                    btnReservarServicio.Hide();
                    string selectedItem = listBoxServicios.SelectedItem.ToString();
                    int index = selectedItem.IndexOf(')');
                    int idExist = Convert.ToInt32(selectedItem.Substring(0, index));
                    string[] registro;
                    registro = objAsignacionServicios.CargarRegistroAsignacion(idExist, IdEvento);
                    if (registro != null) {
                        inList = false;
                        txtBoxDetalle.Text = registro[1];
                        txtBoxCantidad.Text = registro[2];
                    } else {
                        inList = true;
                        Tuple<string, int, int, int> valueTuple = null;
                        valueTuple = VerificarAsignacionLista(idExist);
                        txtBoxDetalle.Text = valueTuple.Item1;
                        txtBoxCantidad.Text = valueTuple.Item2.ToString();
                    }
                }
            }
        }

        private void btnEliminarResServ_Click(object sender, EventArgs e) {
            if (listBoxServicios.SelectedIndex != -1) {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este servicio asignado al evento?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    string selectedItem = listBoxServicios.SelectedItem.ToString();
                    int index = selectedItem.IndexOf(')');
                    int idExist = Convert.ToInt32(selectedItem.Substring(0, index));
                    if (!inList) {
                        objAsignacionServicios.EliminarAsignacionEspecifica(
                            IdEvento,
                            idExist);
                    } else {
                        for (int i = 0; i < listaAsignaciones.Count; i++) {
                            if (listaAsignaciones[i].Item4 == idExist) {
                                listaAsignaciones.RemoveAt(i);
                            }
                        }
                    }
                    listBoxServicios.Items.Remove(listBoxServicios.SelectedItem);
                    txtBoxCantidad.Enabled = false;
                    txtBoxCantidad.Clear();
                    txtBoxDetalle.Enabled = false;
                    txtBoxDetalle.Clear();
                    btnEditResServ.Hide();
                    btnEliminarResServ.Hide();
                    btnReservarServicio.Show();
                    MessageBox.Show("Asignación eliminada correctamente");
                    // Refrescar datagridview
                    DateTime fecha = objAsignacionServicios.ObtenerFechaEvento(IdEvento);
                    ListarExistenciasServicios(fecha);
                    inList = false;
                    btnFinalizarAsignacion.Enabled = true;
                }
            }
        }

        private void btnEditResServ_Click(object sender, EventArgs e) {
            if (listBoxServicios.SelectedIndex != -1) {
                if (FieldsValidation()) {
                    string selectedItem = listBoxServicios.SelectedItem.ToString();
                    int index = selectedItem.IndexOf(")");
                    int idExist = Convert.ToInt32(selectedItem.Substring(0, index));
                    if (!inList) {
                        objAsignacionServicios.EditarAsignacionEspecifica(
                            IdEvento,
                            idExist,
                            txtBoxDetalle.Text,
                            Convert.ToInt32(txtBoxCantidad.Text));
                    } else {
                        for (int i = 0; i < listaAsignaciones.Count; i++) {
                            if (listaAsignaciones[i].Item4 == idExist) {
                                var asignacionActualizada = Tuple.Create(
                                    txtBoxDetalle.Text, 
                                    Convert.ToInt32(txtBoxCantidad.Text),
                                    IdEvento,
                                    idExist);
                                listaAsignaciones[i] = asignacionActualizada;
                            }
                        }
                    }
                    int dashIndex = selectedItem.LastIndexOf("-");
                    string newItem = selectedItem.Substring(0, dashIndex).Trim();
                    string nuevaCantidad = $"{newItem} - {txtBoxCantidad.Text}";
                    listBoxServicios.Items[listBoxServicios.SelectedIndex] = nuevaCantidad;
                    MessageBox.Show("Asignación actualizada correctamente");
                    txtBoxCantidad.Clear();
                    txtBoxDetalle.Clear();
                    btnEditResServ.Hide();
                    btnEliminarResServ.Hide();
                    btnReservarServicio.Show();
                    txtBoxDetalle.Enabled = false;
                    txtBoxCantidad.Enabled = false;
                    // Refrescar datagridview
                    DateTime fecha = objAsignacionServicios.ObtenerFechaEvento(IdEvento);
                    ListarExistenciasServicios(fecha);
                    listBoxServicios.SelectedIndex = -1;
                    inList = false;
                    btnFinalizarAsignacion.Enabled = true;

                } else
                    MessageBox.Show("Campos invalidos, por favor verifiquelos.");
            }
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
