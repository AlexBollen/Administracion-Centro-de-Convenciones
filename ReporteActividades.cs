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
    public partial class ReporteActividades : Form {
        public ReporteActividades() {
            InitializeComponent();
        }

        private void ReporteActividades_Load(object sender, EventArgs e) {

            this.reportViewer1.RefreshReport();
        }
    }
}
