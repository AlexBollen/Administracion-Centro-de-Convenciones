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
    public partial class Usuarios : Form {
        ClsUsuarios objUsuarios = new ClsUsuarios();
        int IdUsuario, UpdateDireccionId, UpdateContactoId;
        string UpdatePass;
        public Usuarios() {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e) {
            addUser.Hide();
            listUsers.Show();
            ListarUsuarios();
        }

        private void ListarUsuarios() {
            ClsUsuarios objListUsuarios = new ClsUsuarios();
            dataGridViewUsuarios.DataSource = objListUsuarios.ListarUsuarios();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e) {
            listUsers.Show();
            addUser.Hide();
            btnAgregarUsuario.Enabled = true;
            btnEditarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;
            ListarUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e) {
            ClearData();
            btnEditarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            btnIngresarUsuario.Show();
            btnEditUsuario.Hide();
            ListarRoles();
            addUser.Show();
            listUsers.Hide();
        }

        private void ClearData() {
            txtBoxNombreUsr.Clear();
            txtBoxUsername.Clear();
            txtBoxPass1.Clear();
            txtBoxPass2.Clear();
            txtBoxDireccion.Clear();
            txtBoxTelefono.Clear();
            txtBoxCorreo.Clear();
        }

        private void ListarRoles() {
            ClsUsuarios objRoles = new ClsUsuarios();
            comboBoxRoles.DataSource = objRoles.ListarRoles();
            comboBoxRoles.DisplayMember = "NombreRol";
            comboBoxRoles.ValueMember = "IdRol";
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e) {
            if (dataGridViewUsuarios.SelectedRows.Count > 0) {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el usuario?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    objUsuarios.EliminarUsuario(Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el usuario");
                    ListarUsuarios();
                }
            } else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            btnIngresarUsuario.Show();
            btnEditUsuario.Hide();
            string newPass;
            bool newEstado;
            if (txtBoxPass1.Text == "")
                newPass = UpdatePass;
            else
                newPass = txtBoxPass1.Text;
            if (comboBoxEstadoUsuario.Text == "Activo")
                newEstado = true;
            else
                newEstado = false;
            if (!(txtBoxPass1.Text == txtBoxPass2.Text))
                MessageBox.Show("Las contraseñas no coinciden");
            else
            {
                objUsuarios.EditarUsuario(
                IdUsuario,
                txtBoxUsername.Text,
                newPass,
                txtBoxNombreUsr.Text,
                newEstado,
                Convert.ToInt32(comboBoxRoles.SelectedValue),
                UpdateDireccionId,
                txtBoxDireccion.Text,
                comboBoxMunicipios.Text,
                comboBoxDeptos.Text,
                UpdateContactoId,
                1,
                txtBoxTelefono.Text,
                txtBoxCorreo.Text
            );
                UpdatePass = "";
                MessageBox.Show("Se actualizo correctamente el usuario");
                btnListarUsuarios.PerformClick();
            }
        }

        private void btnIngresarUsuario_Click(object sender, EventArgs e) {
            bool newEstado;
            if (comboBoxEstadoUsuario.Text == "Activo")
                newEstado = true;
            else
                newEstado = false;
            if (!(txtBoxPass1.Text == txtBoxPass2.Text))
                MessageBox.Show("Las contraseñas no coinciden");
            else
            {
                int idDireccion = objUsuarios.InsertarDireccion(
                    txtBoxDireccion.Text,
                    comboBoxMunicipios.Text,
                    comboBoxDeptos.Text);
                int idContacto = objUsuarios.InsertarContacto(
                    1,
                    txtBoxTelefono.Text,
                    txtBoxCorreo.Text);
                objUsuarios.InsertarUsuario(
                    txtBoxUsername.Text,
                    txtBoxPass1.Text,
                    txtBoxNombreUsr.Text,
                    newEstado,
                    Convert.ToInt32(comboBoxRoles.SelectedValue),
                    idDireccion,
                    idContacto);
                MessageBox.Show("Insertado correctamente");
                ClearData();
                btnEditarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                btnListarUsuarios.PerformClick();
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e) {
            if (dataGridViewUsuarios.SelectedRows.Count > 0) {
                // Control de visualización de componentes
                listUsers.Hide();
                addUser.Show();
                btnIngresarUsuario.Hide();
                btnEditUsuario.Show();
                // Cargar tablas relacionadas a combobox
                ListarRoles();
                // Cargar datos del registro a componentes
                IdUsuario = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells[0].Value);
                string[] registro;
                registro = objUsuarios.CargarRegistroUsuario(IdUsuario);
                txtBoxUsername.Text = registro[1];
                UpdatePass = registro[2];
                txtBoxNombreUsr.Text = registro[3];
                if (Convert.ToBoolean(registro[4]) == true)
                    comboBoxEstadoUsuario.Text = "Activo";
                else
                    comboBoxEstadoUsuario.Text = "Inactivo";
                comboBoxRoles.SelectedValue = registro[5];
                UpdateDireccionId = Convert.ToInt32(registro[6]);
                UpdateContactoId = Convert.ToInt32(registro[7]);
                // Cargar datos de itinerario del evento
                string[] direccion;
                direccion = objUsuarios.CargarRegistroDireccion(Convert.ToInt32(registro[6]));
                txtBoxDireccion.Text = direccion[1];
                comboBoxMunicipios.Text = direccion[2];
                comboBoxDeptos.Text = direccion[3];
                string[] contacto;
                contacto = objUsuarios.CargarRegistroContacto(Convert.ToInt32(registro[7]));
                txtBoxTelefono.Text = contacto[2];
                txtBoxCorreo.Text = contacto[3];
            } else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }
    }
}
