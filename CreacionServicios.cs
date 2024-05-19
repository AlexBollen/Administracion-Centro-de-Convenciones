using Administración_Centro_de_Convenciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones {
    public partial class CreacionServicios : Form {
        ClsCreacionServicios objCreacionServicios = new ClsCreacionServicios();
        int IdServicio, UpdateExistenciaServicioId;
        public CreacionServicios() {
            InitializeComponent();
        }

        private void ListarServicios() {
            ClsCreacionServicios objListServicios = new ClsCreacionServicios();
            dataGridViewServicios.DataSource = objListServicios.ListarServicios();
        }

        private void btnListarServicios_Click(object sender, EventArgs e) {
            listServicios.Show();
            addServicio.Hide();
            btnAgregarServicio.Enabled = true;
            btnEdicionServicio.Enabled = true;
            btnEliminarServicio.Enabled = true;
            ListarServicios();
        }

        private void CreacionServicios_Load(object sender, EventArgs e) {
            listServicios.Show();
            addServicio.Hide();
            ListarServicios();
        }

        private void ClearData() {
            txtBoxNombreServicio.Clear();
            txtBoxDescripcion.Clear();
            txtBoxExistencias.Clear();
            pbValidation1.Hide();
            pbValidation2.Hide();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e) {
            ClearData();
            btnEdicionServicio.Enabled = false;
            btnEliminarServicio.Enabled = false;
            btnIngresarSalon.Show();
            btnEditServicio.Hide();
            addServicio.Show();
            listServicios.Hide();
        }


        private void btnIngresarServicio_Click(object sender, EventArgs e) {
            if (FieldsValidation()) {
                int idServicio = objCreacionServicios.InsertarServicio(
                    txtBoxNombreServicio.Text,
                    txtBoxDescripcion.Text);
                objCreacionServicios.InsertarExistenciaServicio(
                    Convert.ToInt32(txtBoxExistencias.Text),
                    idServicio);
                MessageBox.Show("Insertado correctamente");
                ClearData();
                btnEdicionServicio.Enabled = true;
                btnEliminarServicio.Enabled = true;
                btnListarServicios.PerformClick();
            } else {
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e) {
            if (dataGridViewServicios.SelectedRows.Count > 0) {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este servicio?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    objCreacionServicios.EliminarServicio(Convert.ToInt32(dataGridViewServicios.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el servicio");
                    ListarServicios();
                }
            } else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private void btnEdicionServicio_Click(object sender, EventArgs e) {
            if (dataGridViewServicios.SelectedRows.Count > 0) {
                // Control de visualización de componentes
                ClearData();
                listServicios.Hide();
                addServicio.Show();
                btnEliminarServicio.Enabled = false;
                btnIngresarServicio.Hide();
                btnEditServicio.Show();
                // Cargar datos del registro a componentes
                IdServicio = Convert.ToInt32(dataGridViewServicios.CurrentRow.Cells[0].Value);
                string[] registro;
                registro = objCreacionServicios.CargarRegistroServicio(IdServicio);
                txtBoxNombreServicio.Text = registro[1];
                txtBoxDescripcion.Text = registro[2];
                // Cargar datos de existencias del servicio
                string[] existencias;
                existencias = objCreacionServicios.CargarRegistroExistenciaServicio(IdServicio);
                UpdateExistenciaServicioId = Convert.ToInt32(existencias[0]);
                txtBoxExistencias.Text = existencias[1];
            } else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnEditServicio_Click(object sender, EventArgs e) {
            if (FieldsValidation()) {
                objCreacionServicios.EditarServicio(
                IdServicio,
                txtBoxNombreServicio.Text,
                txtBoxDescripcion.Text,
                Convert.ToInt32(txtBoxExistencias.Text));
                MessageBox.Show("Se actualizo correctamente el servicio");
                btnListarServicios.PerformClick();
            } else {
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");
            }
        }

        private bool FieldsValidation() {
            int sum = 0;
            Regex servicenameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,100}$");
            Regex descripValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,150}$");
            Regex existenceValidation = new Regex(@"^[0-9]{1,6}$");
            if (!servicenameValidation.IsMatch(txtBoxNombreServicio.Text)) {
                pbValidation1.Show();
            } else {
                pbValidation1.Hide();
                sum += 1;
            }
            if (!existenceValidation.IsMatch(txtBoxExistencias.Text)) {
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
