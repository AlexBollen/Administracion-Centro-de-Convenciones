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
        }

        private void btnEditarSalon_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalones.SelectedRows.Count > 0)
            {
                // Control de visualización de componentes
                listSalon.Hide();
                addSalon.Show();
                btnIngresarSalon.Hide();
                btnEditSalon.Show();
                // Cargar tablas relacionadas a combobox
                ListarTipos();
                // Cargar datos del registro a componentes
                IdSalon = Convert.ToInt32(dataGridViewSalones.CurrentRow.Cells[0].Value);
                
                MessageBox.Show("IdSalon: " + IdSalon);
                MessageBox.Show(dataGridViewSalones.CurrentRow.ToString());
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
    }
}
