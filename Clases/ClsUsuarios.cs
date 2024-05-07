using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class ClsUsuarios : DBConnection {
        private SqlDataReader LeerFilas;
        public DataTable ListarUsuarios() {
            DataTable tablaUsuarios = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarUsuarios";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaUsuarios.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaUsuarios;
                }
            }
        }

        public DataTable ListarRoles() {
            DataTable tablaRoles = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarRoles";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaRoles.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaRoles;
                }
            }
        }

        public void InsertarUsuario(
            string Usuario,
            string Contrasenia,
            string Nombre,
            int Estado,
            int IdRol,
            int IdDireccion,
            int IdContacto
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarUsuario";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", Usuario);
                        command.Parameters.AddWithValue("@Contrasenia", Contrasenia);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@IdRol", IdRol);
                        command.Parameters.AddWithValue("@IdDireccion", IdDireccion);
                        command.Parameters.AddWithValue("@IdContacto", IdContacto);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el usuario. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public int InsertarDireccion(
            string DireccionDetallada,
            string Departamento,
            string Municipio
        ) {
            int idDireccion;
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarDireccion";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DireccionDetallada", DireccionDetallada);
                        command.Parameters.AddWithValue("@Departamento", Departamento);
                        command.Parameters.AddWithValue("@Municipio", Municipio);

                        SqlParameter idDireccionParameter = new SqlParameter("@IdDireccionOutput", SqlDbType.Int);
                        idDireccionParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(idDireccionParameter);

                        command.ExecuteNonQuery();
                        idDireccion = (int)idDireccionParameter.Value;
                    }
                    return idDireccion;
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar la dirección. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public int InsertarContacto(
            int EstadoContacto
        ) {
            int idContacto;
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarContacto";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EstadoContacto", EstadoContacto);

                        SqlParameter idContactoParameter = new SqlParameter("@IdContactoOutput", SqlDbType.Int);
                        idContactoParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(idContactoParameter);

                        command.ExecuteNonQuery();
                        idContacto = (int)idContactoParameter.Value;
                    }
                    return idContacto;
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el contacto. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public void InsertarContactoTelefono(
            string telefono,
            int IdContacto
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarContactoTelefono";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@IdContacto", IdContacto);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el contacto de teléfono. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public void InsertarContactoMail(
            string Email,
            int IdContacto
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarContactoEmail";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@IdContacto", IdContacto);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el contacto de mail. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public void EliminarUsuario(
            int IdUsuario
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "DELETE Usuario WHERE IdUsuario=" + IdUsuario;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al eliminar el usuario. \nError: {ex.Message}");
                } finally {
                    connection.Close();
                }
            }
        }

        public string[] CargarRegistroUsuario(int IdUsuario) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuario WHERE IdUsuario=" + IdUsuario;
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    string[] row = new string[LeerFilas.FieldCount];
                    try {
                        if (LeerFilas.Read()) {
                            for (int i = 0; i < LeerFilas.FieldCount; i++) {
                                row[i] = LeerFilas[i].ToString();
                            }
                            return row;
                        } else {
                            return null;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("No se encontro el registro.\nError: " + ex.Message);
                        throw;
                    } finally {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }

        public string[] CargarRegistroDireccion(int IdDireccion) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Direccion WHERE IdDireccion=" + IdDireccion;
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    string[] row = new string[LeerFilas.FieldCount];
                    try {
                        if (LeerFilas.Read()) {
                            for (int i = 0; i < LeerFilas.FieldCount; i++) {
                                row[i] = LeerFilas[i].ToString();
                            }
                            return row;
                        } else {
                            return null;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("No se encontro el registro.\nError: " + ex.Message);
                        throw;
                    } finally {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }

        public string[] CargarRegistroContactoTelefono(int IdContactoTelefono) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Contacto_Telefono WHERE IdContactoTelefono=" + IdContactoTelefono;
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    string[] row = new string[LeerFilas.FieldCount];
                    try {
                        if (LeerFilas.Read()) {
                            for (int i = 0; i < LeerFilas.FieldCount; i++) {
                                row[i] = LeerFilas[i].ToString();
                            }
                            return row;
                        } else {
                            return null;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("No se encontro el registro.\nError: " + ex.Message);
                        throw;
                    } finally {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }

        public string[] CargarRegistroContactoEmail(int IdContactoEmail) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Contacto_Email WHERE IdContactoEmail=" + IdContactoEmail;
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    string[] row = new string[LeerFilas.FieldCount];
                    try {
                        if (LeerFilas.Read()) {
                            for (int i = 0; i < LeerFilas.FieldCount; i++) {
                                row[i] = LeerFilas[i].ToString();
                            }
                            return row;
                        } else {
                            return null;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("No se encontro el registro.\nError: " + ex.Message);
                        throw;
                    } finally {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }
    }
}
