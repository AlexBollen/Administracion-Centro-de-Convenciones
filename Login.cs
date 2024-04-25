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
using System.Runtime.InteropServices;

namespace Administración_Centro_de_Convenciones {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void Form1_Load(object sender, EventArgs e) {
            labelError.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtBoxUser.Text != "USUARIO") {
                if (txtBoxPassword.Text != "PASSWORD") {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtBoxUser.Text, txtBoxPassword.Text);
                    if (validLogin) {
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.Show();
                        menu.FormClosed += Logout;
                        this.Hide();
                    } else {
                        labelError.Text = "Credenciales no validas";
                        labelError.Visible = true;
                        txtBoxPassword.UseSystemPasswordChar= false;
                        txtBoxPassword.Text = "PASSWORD";
                        txtBoxUser.Focus();
                    }
                } else {
                    labelError.Text = "Se debe proporcionar la contraseña";
                    labelError.Visible = true;
                }
            } else {
                labelError.Text = "Se deben ingresar credenciales validas";
                labelError.Visible = true;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e) {
            txtBoxPassword.UseSystemPasswordChar = false;
            txtBoxPassword.Text = "PASSWORD";
            txtBoxUser.Text = "USUARIO";
            labelError.Visible = false;
            this.Show();
        }

        private void txtBoxUser_Enter(object sender, EventArgs e) {
            if (txtBoxUser.Text == "USUARIO") {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e) {
            if (txtBoxUser.Text == "") {
                txtBoxUser.Text = "USUARIO";
                txtBoxUser.ForeColor = Color.DimGray;
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e) {
            if (txtBoxPassword.Text == "PASSWORD") {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor = Color.LightGray;
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e) {
            if (txtBoxPassword.Text == "") {
                txtBoxPassword.Text = "PASSWORD";
                txtBoxPassword.ForeColor = Color.DimGray;
                txtBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                buttonLogin.PerformClick();
            }
        }
    }
}
