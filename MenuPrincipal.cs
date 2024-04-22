using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace Administración_Centro_de_Convenciones {
    public partial class MenuPrincipal : Form {
        public MenuPrincipal() {
            InitializeComponent();
        }
        bool btnReportsState = false;
        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleBar_Paint(object sender, PaintEventArgs e) {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void titleBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReports_Click(object sender, EventArgs e) {
            if (!btnReportsState) {
                reportsMenu.Visible = true;
                btnReportsState = true;
            } else if (btnReportsState) {
                reportsMenu.Visible = false;
                btnReportsState = false;
            }
        }

        private void btnSpaces_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
            OpenViewsForm(new ReporteEscpacios());
        }

        private void btnActivities_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
            OpenViewsForm(new ReporteActividades());
        }

        private void btnOrganizers_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
            OpenViewsForm(new ReportesOrganizador());
        }

        private void btnCalendar_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
            OpenViewsForm(new ReporteCalendario());
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Form1 loginWindow = new Form1();
            loginWindow.Show();
            this.Dispose();
        }

        private void btnReports_MouseHover(object sender, EventArgs e) {
        }

        private void btnReports_MouseLeave(object sender, EventArgs e) {
            
        }

        private void OpenViewsForm(object formhija) {
            if (this.controlPanel.Controls.Count > 0) 
                this.controlPanel.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.controlPanel.Controls.Add(fh);
            this.controlPanel.Tag = fh;
            fh.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e) {
            OpenViewsForm(new Reservas());
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            OpenViewsForm(new Menu());
        }

        private void label1_Click(object sender, EventArgs e) {
            OpenViewsForm(new Menu());
        }

        private void label2_Click(object sender, EventArgs e) {
            OpenViewsForm(new Menu());
        }

        private void button2_Click(object sender, EventArgs e) {
            OpenViewsForm(new Servicios());
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            OpenViewsForm(new Configuracion());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e) {
            label1_Click(null, e);
        }
    }
}
