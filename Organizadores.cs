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
    public partial class Organizadores : Form {
        ClsOrganizadores objOrganizadores = new ClsOrganizadores();
        int IdOrganizador,UpdatePersonaId;
        public Organizadores() {
            InitializeComponent();
        }

        private void btnListarOrganizadores_Click(object sender, EventArgs e)
        {
            listOrganizador.Show();
            addOrganizador.Hide();
            btnAgregarOrganizador.Enabled = true;
            btnEdiicionOrganizador.Enabled = true;
            btnEliminarOrganizador.Enabled = true;
            ListarOrganizadores();
        }

        private void Organizadores_Load(object sender, EventArgs e)
        {
            listOrganizador.Show();
            addOrganizador.Hide();
            btnAgregarOrganizador.Enabled = true;
            btnEdiicionOrganizador.Enabled = true;
            btnEliminarOrganizador.Enabled = true;
            ListarOrganizadores();
        }
        private void ListarOrganizadores()
        {
            ClsOrganizadores objListOrganizadores = new ClsOrganizadores();
            dataGridViewOrganizadores.DataSource = objListOrganizadores.ListarOrganizadores();
        }
        private void ClearData()
        {
            txtBoxNombreOrganizador.Clear();
        }

        private void btnAgregarOrganizador_Click(object sender, EventArgs e)
        {
            listOrganizador.Hide();
            addOrganizador.Show();
            btnEdiicionOrganizador.Enabled = false;
            btnEliminarOrganizador.Enabled = false;
            btnIngresarOrganizador.Show();
            btnEditOrganizador.Hide() ;
            ClearData();
            ListarOrganizadores();
        }

        private void btnIngresarOrganizador_Click(object sender, EventArgs e)
        {
            int idPersona = objOrganizadores.InsertarPersona(
                txtBoxNombreOrganizador.Text);
            objOrganizadores.InsertarOrganizador(
                comboBoxEstadoOrganizador.SelectedItem.ToString(),
                idPersona
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEdiicionOrganizador.Enabled = true;
            btnEliminarOrganizador.Enabled = true;
            btnListarOrganizadores.PerformClick();
        }

        private void btnEdiicionOrganizador_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrganizadores.SelectedRows.Count > 0)
            {
                // Control de visualización de componentes
                listOrganizador.Hide();
                addOrganizador.Show();
                btnIngresarOrganizador.Hide();
                btnEditOrganizador.Show();
                // Cargar datos del organizador a componentes
                IdOrganizador = Convert.ToInt32(dataGridViewOrganizadores.CurrentRow.Cells[0].Value);
                string[] organizador;
                organizador = objOrganizadores.CargarRegistroOrganizador(IdOrganizador);
                comboBoxEstadoOrganizador.SelectedItem = organizador[1];
                UpdatePersonaId = Convert.ToInt32(organizador[2]);
                // Cargar datos de persona 
                string[] persona;
                persona = objOrganizadores.CargarRegistroPersona(Convert.ToInt32(organizador[2]));
                txtBoxNombreOrganizador.Text = persona[1];


            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnEliminarOrganizador_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrganizadores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el evento?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    objOrganizadores.EliminarOrganizador(Convert.ToInt32(dataGridViewOrganizadores.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el evento");
                    ListarOrganizadores();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private void btnEditOrganizador_Click(object sender, EventArgs e)
        {
            objOrganizadores.EditarOrganizador(
                IdOrganizador,
                comboBoxEstadoOrganizador.SelectedItem.ToString(),
                UpdatePersonaId,
                txtBoxNombreOrganizador.Text
            );
            MessageBox.Show("Se actualizo correctamente el organizador");
            btnListarOrganizadores.PerformClick();
        }
    }
}
