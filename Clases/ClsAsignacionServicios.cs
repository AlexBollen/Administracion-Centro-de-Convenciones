using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class ClsAsignacionServicios : DBConnection {
        private SqlDataReader LeerFilas;
        public DataTable ListarServicios() {
            DataTable tablaServicios = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarAsignacionEventos";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaServicios.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaServicios;
                }
            }
        }

        public DataTable ListarExistenciasServicios(DateTime FechaEvento) {
            DataTable tablaExistenciasServicios = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ObtenerExistenciasServicios";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FechaEvento", FechaEvento.Date);
                    LeerFilas = command.ExecuteReader();
                    tablaExistenciasServicios.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaExistenciasServicios;
                }
            }
        }

        public DateTime ObtenerFechaEvento(int IdEvento) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ObtenerFechaEvento";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEvento", IdEvento);

                    using (var reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            return reader.GetDateTime(0);
                        } else {
                            throw new Exception("No se encontró la fecha para el evento especificado.");
                        }
                    }
                }
            }
        }

        public DataTable ListarServiciosEvento(int IdEvento) {
            DataTable tablaServiciosEvento = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ObtenerServiciosEvento";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEvento", IdEvento);
                    LeerFilas = command.ExecuteReader();
                    tablaServiciosEvento.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaServiciosEvento;
                }
            }
        }

        public void InsertarAsignacionServicio(
            string Detalle,
            int Cantidad,
            int IdEvento,
            int IdExistencia
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarAsignacionServicio";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Detalle", Detalle);
                        command.Parameters.AddWithValue("@Cantidad", Cantidad);
                        command.Parameters.AddWithValue("@IdEvento", IdEvento);
                        command.Parameters.AddWithValue("@IdExistencia", IdExistencia);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al asignar el servicio al evento. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public void ActualizarEstadoAsignacion(int IdEvento, int estado) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = $"UPDATE Evento SET Servicios={estado} WHERE IdEvento={IdEvento}";
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

        public void EliminarAsignaciones(
            int IdEvento
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = $"DELETE Solicita WHERE IdEvento={IdEvento}";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al eliminar los servicios del evento. \nError: {ex.Message}");
                } finally {
                    connection.Close();
                }
            }
        }

    }
}
