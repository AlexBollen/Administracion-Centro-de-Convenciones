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
        }

        private void btnActivities_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
        }

        private void btnOrganizers_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
        }

        private void btnCalendar_Click(object sender, EventArgs e) {
            reportsMenu.Visible = false;
            btnReportsState = false;
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
    }
}
