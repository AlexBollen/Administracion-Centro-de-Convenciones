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
using System.Text.RegularExpressions;

namespace Administración_Centro_de_Convenciones {
    public partial class Usuarios : Form {
        ClsUsuarios objUsuarios = new ClsUsuarios();
        int IdUsuario, UpdateDireccionId, UpdateContactoId;
        string UpdatePass;
        bool samePass = false;
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
            pbValidation1.Hide();
            pbValidation2.Hide();
            pbValidation3.Hide();
            pbValidation4.Hide();
            pbValidation5.Hide();
            pbValidation6.Hide();
            pbValidation7.Hide();
            pbValidation8.Hide();
            pbValidation9.Hide();
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
            string newPass;
            bool newEstado, verif;
            if (txtBoxPass1.Text == "") {
                newPass = UpdatePass;
                samePass = true;
                verif = true;
            } else {
                if (!(txtBoxPass1.Text == txtBoxPass2.Text)) {
                    MessageBox.Show("Las contraseñas no coinciden");
                    newPass = "";
                    verif = false;
                } else {
                    samePass = false;
                    newPass = txtBoxPass1.Text;
                    verif = true;
                }
            }

            if (verif && FieldsValidation()) {
                if (comboBoxEstadoUsuario.Text == "Activo")
                    newEstado = true;
                else
                    newEstado = false;
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
                btnIngresarUsuario.Show();
                btnEditUsuario.Hide();
                btnListarUsuarios.PerformClick();
            } else {
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");
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
                if (FieldsValidation())
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
                } else{
                    MessageBox.Show("Campos invalidos, por favor verifiquelos.");
                }
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e) {
            ClearData();
            if (dataGridViewUsuarios.SelectedRows.Count > 0) {
                // Control de visualización de componentes
                listUsers.Hide();
                addUser.Show();
                btnIngresarUsuario.Hide();
                btnEditUsuario.Show();
                btnEliminarUsuario.Enabled = false;
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

        private bool FieldsValidation(){
            int sum = 0;
            Regex usernameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,50}$");
            Regex passValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,126}$");
            Regex nameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,100}$");
            Regex addressValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.\d]{1,150}$");
            Regex phoneValidation = new Regex(@"^[0-9]{8}$");
            Regex mailValidation = new Regex(@"^[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*@[a-zA-Z0-9]+([.][a-zA-Z0-9]+){1,3}$");
            if (!usernameValidation.IsMatch(txtBoxUsername.Text)){
                pbValidation1.Show();
            } else{
                pbValidation1.Hide();
                sum += 1;
            }
            if (!samePass) {
                if (!passValidation.IsMatch(txtBoxPass1.Text)) {
                    pbValidation2.Show();
                } else {
                    pbValidation2.Hide();
                    sum += 1;
                }
            } else {
                sum+= 1;
            }
            if (!nameValidation.IsMatch(txtBoxNombreUsr.Text)){
                pbValidation5.Show();
            } else{
                pbValidation5.Hide();
                sum += 1;
            }
            if (!addressValidation.IsMatch(txtBoxDireccion.Text)){
                pbValidation3.Show();
            } else{
                pbValidation3.Hide();
                sum += 1;
            }
            if (!phoneValidation.IsMatch(txtBoxTelefono.Text)){
                pbValidation4.Show();
            } else{
                pbValidation4.Hide();
                sum += 1;
            }
            if (!mailValidation.IsMatch(txtBoxCorreo.Text)){
                pbValidation6.Show();
            } else{
                pbValidation6.Hide();
                sum += 1;
            }
            if (comboBoxEstadoUsuario.Text == "")
                pbValidation7.Show();
            else{
                pbValidation7.Hide();
                sum += 1;
            }
            if (comboBoxDeptos.Text == "")
                pbValidation8.Show();
            else{
                pbValidation8.Hide();
                sum += 1;
            }
            if (comboBoxMunicipios.Text == "")
                pbValidation9.Show();
            else{
                pbValidation9.Hide();
                sum += 1;
            }
            if (sum == 9)
                return true;
            else 
                return false;
        }
    }
}
