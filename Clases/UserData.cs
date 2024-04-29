using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Administración_Centro_de_Convenciones.Cache;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class UserData : DBConnection {
        public bool Login(string user, string pass) {
            using(var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuario where Usuario=@user and Contrasenia=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            UserLoginCache.IdUsuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.Usuario = reader.GetString(1);
                            UserLoginCache.IdRol = reader.GetInt32(5);
                            UserLoginCache.IdDireccion = reader.GetInt32(6);
                            UserLoginCache.IdContacto = reader.GetInt32(7);
                        }
                        UserLoginCache.NombreRol = NombreRol(UserLoginCache.IdRol);
                        return true;
                    } else {
                        return false;
                    }
                }
            }
        }

        public string NombreRol(int idRol) {
            using (var connection = GetConnection()) {
                connection.Open();
                using(var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Rol where IdRol=@idRol";
                    command.Parameters.AddWithValue("@idRol", idRol);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    string rolName = "";
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            rolName = reader.GetString(1);
                        }
                        return rolName;
                    } else {
                        return rolName;
                    }
                }
            }
        }
    }
}
