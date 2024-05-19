using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class ClsCreacionServicios : DBConnection {
        private SqlDataReader LeerFilas;
        public DataTable ListarServicios() {
            DataTable tablaUsuarios = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarServicios";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaUsuarios.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaUsuarios;
                }
            }
        }

        public int InsertarServicio(
            string NombreServicio,
            string DescripcionServicio
        ) {
            int idServicio;
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarServicio";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreServicio", NombreServicio);
                        command.Parameters.AddWithValue("@DescripcionServicio", DescripcionServicio);

                        SqlParameter idDireccionParameter = new SqlParameter("@IdServicioOutput", SqlDbType.Int);
                        idDireccionParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(idDireccionParameter);

                        command.ExecuteNonQuery();
                        idServicio = (int)idDireccionParameter.Value;
                    }
                    return idServicio;
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el servicio. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public void InsertarExistenciaServicio(
            int CantidadTotal,
            int IdServicio
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarExistenciaServicio";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CantidadTotal", CantidadTotal);
                        command.Parameters.AddWithValue("@IdServicio", IdServicio);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar las existencias del servicio. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public void EditarServicio(
            int IdServicio,
            string NombreServicio,
            string DescripcionServicio,
            int CantidadTotal
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "ActualizarServicio";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdServicio", IdServicio);
                        command.Parameters.AddWithValue("@NombreServicio", NombreServicio);
                        command.Parameters.AddWithValue("@DescripcionServicio", DescripcionServicio);
                        command.Parameters.AddWithValue("@CantidadTotal", CantidadTotal);
                        command.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al actualizar el servicio. \nError: {ex.Message}");
                } finally {
                    connection.Close();
                }
            }
        }

        public string[] CargarRegistroServicio(int IdServicio) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Servicios WHERE IdServicio=" + IdServicio;
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

        public string[] CargarRegistroExistenciaServicio(int IdServicio) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ExistenciaServicio WHERE IdServicio=" + IdServicio;
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

        public void EliminarServicio(
            int IdServicio
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "DELETE ExistenciaServicio WHERE IdServicio=" + IdServicio;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "DELETE Servicios WHERE IdServicio=" + IdServicio;
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

    }
}
