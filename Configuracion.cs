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
    public partial class Configuracion : Form {
        public Configuracion() {
            InitializeComponent();
        }

        private void OpenViewsForm(object formhija) {
            if (this.panelSettings.Controls.Count > 0)
                this.panelSettings.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelSettings.Controls.Add(fh);
            this.panelSettings.Tag = fh;
            fh.Show();
        }

        private void btnOrganizadores_Click(object sender, EventArgs e) {
            OpenViewsForm(new Organizadores());
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {
            OpenViewsForm(new Usuarios());
        }

        private void btnSalones_Click(object sender, EventArgs e) {
            OpenViewsForm(new Salones());
        }

        private void btnTipoEvento_Click(object sender, EventArgs e) {
            OpenViewsForm(new TiposEvento());
        }

        private void btnTipoSalon_Click(object sender, EventArgs e) {
            OpenViewsForm(new TiposSalon());
        }
    }
}
