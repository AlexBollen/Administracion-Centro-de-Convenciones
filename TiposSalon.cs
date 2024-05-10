﻿using Administración_Centro_de_Convenciones.Clases;
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
    public partial class TiposSalon : Form {
        ClsTipoSalon objTipoSalones = new ClsTipoSalon();
        int IdTipoSalon;


        public TiposSalon() {
            InitializeComponent();
        }

        private void btnListarSalones_Click(object sender, EventArgs e)
        {
            listTipoSalon.Show();
            addTipoSalon.Hide();
            btnAgregarSalon.Enabled = true;
            btnEdiicionTipoSalon.Enabled = true;
            btnEliminarTipoSalon.Enabled = true;
            ListarTipoSalones();
        }

        private void TiposSalon_Load(object sender, EventArgs e)
        {
            addTipoSalon.Hide();
            listTipoSalon.Show();
            ListarTipoSalones();
        }
        private void ListarTipoSalones()
        {
            ClsTipoSalon objListTipoSalones = new ClsTipoSalon();
            dataGridViewTipoSalones.DataSource = objListTipoSalones.ListarTipoSalones();
        }

        private void btnAgregarSalon_Click(object sender, EventArgs e)
        {
            ClearData();
            btnEdiicionTipoSalon.Enabled = false;
            btnEliminarTipoSalon.Enabled = false;
            btnIngresarSalon.Show();
            btnEditTipoSalon.Hide();
            addTipoSalon.Show();
            listTipoSalon.Hide();
        }
        private void ClearData()
        {
            txtBoxNombreTipoSalon.Clear();
            txtBoxExistencias.Clear();
        }

        private void btnIngresarSalon_Click(object sender, EventArgs e)
        {
            objTipoSalones.InsertarTipoSalon(
            txtBoxNombreTipoSalon.Text,
            Convert.ToInt32(txtBoxExistencias.Text));
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEdiicionTipoSalon.Enabled = true;
            btnEliminarTipoSalon.Enabled = true;
            btnListarSalones.PerformClick();
        }

        private void btnEdiicionTipoSalon_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoSalones.SelectedRows.Count > 0)
            {
                // Control de visualización de componentes
                listTipoSalon.Hide();
                addTipoSalon.Show();
                btnIngresarSalon.Hide();
                btnEditTipoSalon.Show();
                // Cargar datos del registro a componentes
                IdTipoSalon = Convert.ToInt32(dataGridViewTipoSalones.CurrentRow.Cells[0].Value);
                string[] registro;
                registro = objTipoSalones.CargarRegistroTipoSalon(IdTipoSalon);
                txtBoxNombreTipoSalon.Text = registro[1];
                txtBoxExistencias.Text = registro[2].ToString();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnEditTipoSalon_Click(object sender, EventArgs e)
        {
            btnIngresarSalon.Show();
            btnEditTipoSalon.Hide();
            objTipoSalones.EditarTipoSalon(
            IdTipoSalon,
            txtBoxNombreTipoSalon.Text,
            Convert.ToInt32(txtBoxExistencias.Text)
        );
            MessageBox.Show("Se actualizo correctamente el tipo de salón");
            btnListarSalones.PerformClick();
        }

        private void btnEliminarTipoSalon_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoSalones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el tipo de salón?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    objTipoSalones.EliminarTipoSalon(Convert.ToInt32(dataGridViewTipoSalones.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el tipo de salón");
                    ListarTipoSalones();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }
    }
}
