using Administración_Centro_de_Convenciones.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class ClsEventos : DBConnection{
        private SqlDataReader LeerFilas;
        public DataTable ListarEventos() {
            DataTable tablaEventos = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarEventos";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaEventos.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaEventos;
                }
            }
        }

        public DataTable ListarSalones() {
            DataTable tablaSalones = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarSalon";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaSalones.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaSalones;
                }
            }
        }

        public DataTable ListarOrganizadores() {
            DataTable tablaOrganizadores = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarOrganizadores";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaOrganizadores.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaOrganizadores;
                }
            }
        }

        public DataTable ListarTiposEvento() {
            DataTable tablaTiposEvento = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarTipoEvento";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaTiposEvento.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaTiposEvento;
                }
            }
        }

        public void InsertarReserva(
            string Nombre,
            string Descripcion,
            string EstadoEvento,
            int CantidadAsistentes,
            DateTime FechaReserva,
            int IdItinerario,
            int IdResponsable,
            int IdOrganizador,
            int IdTipoEvento,
            int IdSalon
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarEvento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@EstadoEvento", EstadoEvento);
                        command.Parameters.AddWithValue("@CantidadAsistentes", CantidadAsistentes);
                        command.Parameters.AddWithValue("@FechaReserva", FechaReserva.Date);
                        command.Parameters.AddWithValue("@IdItinerario", IdItinerario);
                        command.Parameters.AddWithValue("@IdResponsable", IdResponsable);
                        command.Parameters.AddWithValue("@IdOrganizador", IdOrganizador);
                        command.Parameters.AddWithValue("@IdTipoEvento", IdTipoEvento);
                        command.Parameters.AddWithValue("@IdSalon", IdSalon);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el evento. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public int InsertarItinerario(
            DateTime FechaInicio,
            DateTime FechaCulminacion,
            string HoraInicio,
            string HoraCulminacion
        ) {
            int idItinerario;
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarItinerario";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FechaInicio", FechaInicio.Date);
                        command.Parameters.AddWithValue("@FechaCulminacion", FechaCulminacion.Date);
                        command.Parameters.AddWithValue("@HoraInicio", HoraInicio);
                        command.Parameters.AddWithValue("@HoraCulminacion", HoraCulminacion);

                        SqlParameter idItinerarioParameter = new SqlParameter("@IdItinerario", SqlDbType.Int);
                        idItinerarioParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(idItinerarioParameter);

                        command.ExecuteNonQuery();
                        idItinerario = (int)idItinerarioParameter.Value;
                    }
                    return idItinerario;
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el itinerario. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public int InsertarPersona(
            string NombrePersona
        ) {
            int idPersona;
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarPersona";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombrePersona", NombrePersona);

                        SqlParameter idPersonaParameter = new SqlParameter("@IdPersona", SqlDbType.Int);
                        idPersonaParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(idPersonaParameter);

                        command.ExecuteNonQuery();
                        idPersona = (int)idPersonaParameter.Value;
                    }
                    return idPersona;
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar la persona. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
        }

        public int InsertarResponsable(
            string NombreComercial, 
            int IdPersona
            ) {
            int idResponsable;
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "InsertarResponsable";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreComercial", NombreComercial);
                        command.Parameters.AddWithValue("@IdPersona", IdPersona);

                        SqlParameter idResponsableParameter = new SqlParameter("@IdResponsableOutput", SqlDbType.Int);
                        idResponsableParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(idResponsableParameter);

                        command.ExecuteNonQuery();
                        idResponsable = (int)idResponsableParameter.Value;
                    }
                    return idResponsable;
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al registrar el responsable. \nError: {ex.Message}");
                    throw;
                } finally {
                    connection.Close();
                }
            }
            
        }

        public void EditarReserva(
            int IdEvento,
            string Nombre,
            string Descripcion,
            string EstadoEvento,
            int CantidadAsistentes,
            int IdOrganizador,
            int IdTipoEvento,
            int IdSalon,
            int IdItinerario,
            DateTime FechaInicio,
            DateTime FechaCulminacion,
            string HoraInicio,
            string HoraCulminacion,
            int IdResponsable, 
            string NombreComercial,
            int IdPersona,
            string NombrePersona
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "ActualizarEvento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdEvento", IdEvento);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@EstadoEvento", EstadoEvento);
                        command.Parameters.AddWithValue("@CantidadAsistentes", CantidadAsistentes);
                        command.Parameters.AddWithValue("@IdOrganizador", IdOrganizador);
                        command.Parameters.AddWithValue("@IdTipoEvento", IdTipoEvento);
                        command.Parameters.AddWithValue("@IdSalon", IdSalon);
                        command.Parameters.AddWithValue("@IdItinerario", IdItinerario);
                        command.Parameters.AddWithValue("@FechaInicio", FechaInicio.Date);
                        command.Parameters.AddWithValue("@FechaCulminacion", FechaCulminacion.Date);
                        command.Parameters.AddWithValue("@HoraInicio", HoraInicio);
                        command.Parameters.AddWithValue("@HoraCulminacion", HoraCulminacion);
                        command.Parameters.AddWithValue("@IdResponsable", IdResponsable);
                        command.Parameters.AddWithValue("@NombreComercial", NombreComercial);
                        command.Parameters.AddWithValue("@IdPersona", IdPersona);
                        command.Parameters.AddWithValue("@NombrePersona", NombrePersona);
                        command.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al actualizar el evento. \nError: {ex.Message}");
                } finally {
                    connection.Close();
                }
            }
        }

        public void EliminarReserva(
            int IdEvento
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "DELETE Evento WHERE IdEvento=" + IdEvento;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                } catch(Exception ex) {
                    MessageBox.Show($"Ocurrio un error al eliminar el evento. \nError: {ex.Message}");
                } finally {
                    connection.Close();
                }
            }
        }

        public string[] CargarRegistroEvento(int IdEvento) {
            List<string[]> listaRegistro = new List<string[] > ();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Evento WHERE IdEvento="+IdEvento;
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
                    } catch (Exception ex){
                        MessageBox.Show("No se encontro el registro.\nError: " + ex.Message);
                        throw;
                    } finally {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }

        public string[] CargarRegistroItinerario(int IdItinerario) {
            List<string[]> listaItinerario = new List<string[]>();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Itinerario WHERE IdItinerario=" + IdItinerario;
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
                        MessageBox.Show($"No se encontro el registro del itinerario.\nError: {ex.Message}");
                        throw;
                    } finally {
                        connection.Close();
                        LeerFilas.Close();
                    }
                }
            }
        }

        public string [] CargarRegistroResponsable(int IdResponsable) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Responsable WHERE IdResponsable=" + IdResponsable;
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
                        MessageBox.Show($"No se encontro el registro del responsable.\nError: {ex.Message}");
                        throw;
                    } finally {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }

        public string[] CargarRegistroPersona(int IdPersona) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Persona WHERE IdPersona=" + IdPersona;
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
                        MessageBox.Show($"No se encontro el registro de la persona.\nError: {ex.Message}");
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
