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
                    command.CommandText = "ListarSalones";
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
                    command.Parameters.Clear();
                }
            }
            return idItinerario;
        }

        public int InsertarPersona(
            string NombrePersona
        ) {
            int idPersona;
            using (var connection = GetConnection()) {
                connection.Open();
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
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
            return idPersona;
        }

        public int InsertarResponsable(
            string NombreComercial, 
            int IdPersona
            ) {
            int idResponsable;
            using (var connection = GetConnection()) {
                connection.Open();
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
                    MessageBox.Show("Id responsable: " + idResponsable.ToString());
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
            return idResponsable;
        }

        public void EditarReserva(
            int IdEvento,
            string Nombre,
            string Descripcion,
            string EstadoEvento,
            int CantidadAsistentes,
            int IdOrganizador,
            int IdTipoEvento,
            int IdSalon
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Evento SET " +
                        "Nombre="+Nombre+
                        ",Descripcion="+Descripcion+
                        ",EstadoEvento="+EstadoEvento+
                        ",CantidadAsistentes="+CantidadAsistentes+
                        ",IdOrganizador="+IdOrganizador+
                        ",IdTipoEvento="+IdTipoEvento+
                        ",IdSalon="+IdSalon+
                        " WHERE IdEvento="+IdEvento;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void EliminarReserva(
            int IdEvento
        ) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "DELETE Evento WHERE IdEvento="+IdEvento;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

    }
}
