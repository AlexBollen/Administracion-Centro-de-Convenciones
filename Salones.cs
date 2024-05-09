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
    public partial class Salones : Form {
        ClsSalones objUsuarios = new ClsSalones();
        int IdSalon;

        public Salones() {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnListarSalones_Click(object sender, EventArgs e)
        {
            listSalones.Show();
            addSalon.Hide();
            btnAgregarSalon.Enabled = true;
            btnEditarSalon.Enabled = true;
            btnEliminarSalon.Enabled = true;
            ListarSalones();
        }

        private void Salones_Load(object sender, EventArgs e)
        {
            addSalon.Hide();
            listSalones.Show();
            ListarSalones();
        }

        private void ListarSalones()
        {
            ClsSalones objListSalones = new ClsSalones();
            dataGridViewSalones.DataSource = objListSalones.ListarSalones();
        }

        private void btnAgregarSalon_Click(object sender, EventArgs e)
        {
            ClearData();
            btnEditarSalon.Enabled = false;
            btnEliminarSalon.Enabled = false;
            btnIngresarSalon.Show();
            btnEditSalon.Hide();
            ListarTipos();
            addSalon.Show();
            listSalones.Hide();
        }
        private void ClearData()
        {
            txtBoxNombreSalon.Clear();
            txtBoxCapacidad.Clear();
            txtBoxDescripcion.Clear();
        }
        private void ListarTipos()
        {
            ClsSalones objRoles = new ClsSalones();
            comboBoxTipos.DataSource = objRoles.ListarTipos();
            comboBoxTipos.DisplayMember = "NombreTipoSalon";
            comboBoxTipos.ValueMember = "IdTipoSalon";
        }

        private void btnIngresarSalon_Click(object sender, EventArgs e)
        {
            bool newEstado;
            if (comboBoxEstadoSalon.Text == "Activo")
                newEstado = true;
            else
                newEstado = false;
            /*if (!(txtBoxPass1.Text == txtBoxPass2.Text))
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
            }*/
        }

        private void btnEditSalon_Click(object sender, EventArgs e)
        {

        }
    }
}
