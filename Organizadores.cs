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
        int IdOrganizador;
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
            bool Estado;
            if (comboBoxEstadoOrganizador.Text == "Disponible")
                Estado = true;
            else
                Estado = false;
            int idPersona = objOrganizadores.InsertarPersona(
                txtBoxNombreOrganizador.Text);
            objOrganizadores.InsertarOrganizador(
                Estado,
                idPersona
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEdiicionOrganizador.Enabled = true;
            btnEliminarOrganizador.Enabled = true;
            btnListarOrganizadores.PerformClick();
        }
    }
}
