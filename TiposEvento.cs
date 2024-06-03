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
    public partial class TiposEvento : Form {
        ClsTipoEvento objTipoEventos = new ClsTipoEvento();
        int IdTipoEvento;
        public TiposEvento() {
            InitializeComponent();
        }

        private void btnEditTipoSalon_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
            {
                btnIngresarTipoEvento.Show();
                btnEditTipoEvento.Hide();
                objTipoEventos.EditarTipoEvento(
                IdTipoEvento,
                txtBoxNombreTipoEvento.Text,
                txtBoxDescripcion.Text
                );
                MessageBox.Show("Se actualizo correctamente el tipo de evento");
                btnListarTiposEventos.PerformClick();
            } else
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");
        }

        private void btnListarTiposEventos_Click(object sender, EventArgs e)
        {
            listTipoEvento.Show();
            addTipoEvento.Hide();
            btnAgregarTipoEvento.Enabled = true;
            btnEdiicionTipoEvento.Enabled = true;
            btnEliminarTipoEvento.Enabled = true;
            ListarTipoEventos();
        }
        private void ListarTipoEventos()
        {
            ClsTipoEvento objListTipoEventos = new ClsTipoEvento();
            dataGridViewTipoEventos.DataSource = objListTipoEventos.ListarTipoEventos();
        }

        private void TiposEvento_Load(object sender, EventArgs e)
        {
            addTipoEvento.Hide();
            listTipoEvento.Show();
            ListarTipoEventos();
        }

        private void btnAgregarTipoEvento_Click(object sender, EventArgs e)
        {
            ClearData();
            btnEdiicionTipoEvento.Enabled = false;
            btnEliminarTipoEvento.Enabled = false;
            btnIngresarTipoEvento.Show();
            btnEditTipoEvento.Hide();
            addTipoEvento.Show();
            listTipoEvento.Hide();
        }
        private void ClearData()
        {
            txtBoxNombreTipoEvento.Clear();
            txtBoxDescripcion.Clear();
            pbValidation1.Hide();
        }

        private void btnIngresarTipoEvento_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
            {
                objTipoEventos.InsertarTipoEvento(
                txtBoxNombreTipoEvento.Text,
                txtBoxDescripcion.Text);
                MessageBox.Show("Insertado correctamente");
                ClearData();
                btnEdiicionTipoEvento.Enabled = true;
                btnEliminarTipoEvento.Enabled = true;
                btnListarTiposEventos.PerformClick();
            } else
                MessageBox.Show("Campos invalidos, por favor verifiquelos.");
        }

        private void btnEdiicionTipoEvento_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoEventos.SelectedRows.Count > 0)
            {
                // Control de visualización de componentes
                listTipoEvento.Hide();
                addTipoEvento.Show();
                btnIngresarTipoEvento.Hide();
                btnEditTipoEvento.Show();
                btnEliminarTipoEvento.Enabled = false;
                // Cargar datos del registro a componentes
                IdTipoEvento = Convert.ToInt32(dataGridViewTipoEventos.CurrentRow.Cells[0].Value);
                string[] registro;
                registro = objTipoEventos.CargarRegistroTipoEvento(IdTipoEvento);
                txtBoxNombreTipoEvento.Text = registro[1];
                txtBoxDescripcion.Text = registro[2].ToString();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnEliminarTipoEvento_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoEventos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el tipo de evento?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    objTipoEventos.EliminarTipoEvento(Convert.ToInt32(dataGridViewTipoEventos.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el tipo de evento");
                    ListarTipoEventos();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private bool FieldsValidation()
        {
            int sum = 0;
            Regex eventTypeNameValidation = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s.]{1,75}$");
            if (!eventTypeNameValidation.IsMatch(txtBoxNombreTipoEvento.Text))
                pbValidation1.Show();
            else{
                pbValidation1.Hide();
                sum += 1;
            }
            if (sum == 1)
                return true;
            else
                return false;
        }
    }
}
