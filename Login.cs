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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtBoxUser.Text != "") {
                if (txtBoxPassword.Text != "") {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtBoxUser.Text, txtBoxPassword.Text);
                    if (validLogin) {
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.Show();
                        menu.FormClosed += Logout;
                        this.Hide();
                    } else {
                        MessageBox.Show("Credenciales no validas");
                    }
                } else {
                    MessageBox.Show("Proporciona una contraseña");
                }
            } else {
                MessageBox.Show("Proporciona un usuario");
            }
        }

        private void Logout(object sender, FormClosedEventArgs e) {
            txtBoxUser.Clear();
            txtBoxPassword.Clear();
            this.Show();
        }
    }
}
