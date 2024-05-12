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
    public partial class Salones : Form {
        ClsSalones objSalones = new ClsSalones();
        int IdSalon;

        public Salones() {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnListarSalones_Click(object sender, EventArgs e)
        {
            listSalon.Show();
            addSalon.Hide();
            btnAgregarSalon.Enabled = true;
            btnEdiicionSalon.Enabled = true;
            btnEliminarSalon.Enabled = true;
            ListarSalones();
        }

        private void Salones_Load(object sender, EventArgs e)
        {
            addSalon.Hide();
            listSalon.Show();
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
            btnEdiicionSalon.Enabled = false;
            btnEliminarSalon.Enabled = false;
            btnIngresarSalon.Show();
            btnEditSalon.Hide();
            ListarTipos();
            addSalon.Show();
            listSalon.Hide();
        }
        private void ClearData()
        {
            txtBoxNombreSalon.Clear();
            txtBoxCapacidad.Clear();
            txtBoxDescripcion.Clear();
            pbValidation1.Hide();
            pbValidation2.Hide();
            pbValidation3.Hide();
            pbValidation4.Hide();
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
            if (FieldsValidation())
            {
                objSalones.InsertarSalon(
                    txtBoxNombreSalon.Text,
                    comboBoxEstadoSalon.SelectedItem.ToString(),
                    txtBoxDescripcion.Text,
                    Convert.ToInt32(txtBoxCapacidad.Text),
                    Convert.ToInt32(comboBoxTipos.SelectedValue));
                MessageBox.Show("Insertado correctamente");
                ClearData();
                btnEdiicionSalon.Enabled = true;
                btnEliminarSalon.Enabled = true;
                btnListarSalones.PerformClick();
            } else
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");

        }

        private void btnEditarSalon_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalones.SelectedRows.Count > 0)
            {
                ClearData();
                // Control de visualización de componentes
                listSalon.Hide();
                addSalon.Show();
                btnIngresarSalon.Hide();
                btnEditSalon.Show();
                // Cargar tablas relacionadas a combobox
                ListarTipos();
                // Cargar datos del registro a componentes
                IdSalon = Convert.ToInt32(dataGridViewSalones.CurrentRow.Cells[0].Value);
                string[] registro;
                registro = objSalones.CargarRegistroSalon(IdSalon);
                txtBoxNombreSalon.Text = registro[1];
                comboBoxEstadoSalon.SelectedValue = registro[2];
                txtBoxCapacidad.Text = registro[3];
                txtBoxDescripcion.Text = registro[4];
                comboBoxTipos.SelectedValue = registro[5];
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnEditSalon_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
            {
                btnIngresarSalon.Show();
                btnEditSalon.Hide();
                objSalones.EditarSalon(
                IdSalon,
                txtBoxNombreSalon.Text,
                comboBoxEstadoSalon.SelectedItem.ToString(),
                txtBoxDescripcion.Text,
                Convert.ToInt32(txtBoxCapacidad.Text),
                Convert.ToInt32(comboBoxTipos.SelectedValue)
                );
                MessageBox.Show("Se actualizo correctamente el salón");
                btnListarSalones.PerformClick();
            } else
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");

        }

        private void btnEliminarSalon_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el salón?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    objSalones.EliminarSalon(Convert.ToInt32(dataGridViewSalones.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el salón");
                    ListarSalones();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private bool FieldsValidation()
        {
            int sum = 0;
            Regex salonNameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,100}$");
            Regex salonCapacityValidation = new Regex(@"^[\d]{1,5}$");
            if (!salonNameValidation.IsMatch(txtBoxNombreSalon.Text))
                pbValidation1.Show();
            else{
                pbValidation1.Hide();
                sum += 1;
            }
            if (!salonCapacityValidation.IsMatch(txtBoxCapacidad.Text))
                pbValidation2.Show();
            else{
                pbValidation2.Hide();
                sum += 1;
            }
            if (comboBoxEstadoSalon.Text == "")
                pbValidation3.Show();
            else{
                pbValidation3.Hide();
                sum += 1;
            }
            if (comboBoxTipos.Text == "")
                pbValidation4.Show();
            else
            {
                pbValidation4.Hide();
                sum += 1;
            }
            if (sum == 4)
                return true;
            else
                return false;
        }

        private void addSalon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
