using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class ClsReportes : DBConnection{
        private SqlDataReader LeerFilas;

        public DataTable ListarCantidadEspacios() {
            DataTable tablaCantidadEspacios = new DataTable();
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "ListarCantidadTiposSalones";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaCantidadEspacios.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                }
            }
            return tablaCantidadEspacios;
        }
        public DataTable ListarEventosYEspacioes(int IdEvento){
            DataTable EventosFechas = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ReporteActividades";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEvento", IdEvento);
                    LeerFilas = command.ExecuteReader();
                    EventosFechas.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                }
            }
            return EventosFechas;
        }
        public DataTable ListarEventoCalendario(int IdItinerario)
        {
            DataTable EventosFechas = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ReporteCalendario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdItinerario", IdItinerario);
                    LeerFilas = command.ExecuteReader();
                    EventosFechas.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                }
            }
            return EventosFechas;
        }
        public DataTable ListarFechasDisponibles()
        {
            DataTable tablaTiposSalon = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarFechas";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaTiposSalon.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaTiposSalon;
                }
            }
        }
        public DataTable ListarOrganizadorEventosAntiguos(
            string apellido)
        {
            DataTable EventosFechas = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ReporteOrganizadorAntiguos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    LeerFilas = command.ExecuteReader();
                    EventosFechas.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                }
            }
            return EventosFechas;
        }
        public DataTable CargarEventos(
            string apellido)
        {
            DataTable EventosFechas = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ReporteOrganizadorAntiguos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    LeerFilas = command.ExecuteReader();
                    EventosFechas.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                }
            }
            return EventosFechas;
        }

        public Dictionary<DateTime, int> CargarEventosDesdeBaseDeDatos()
        {
            Dictionary<DateTime, int> eventos = new Dictionary<DateTime, int>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select IdItinerario, FechaInicio from Itinerario";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    try
                    {
                        if (LeerFilas.Read())
                        {
                            while (LeerFilas.Read())
                            {
                                int idEvento = LeerFilas.GetInt32(0);
                                DateTime fecha = LeerFilas.GetDateTime(1);
                                eventos[fecha] = idEvento;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se encontro el registro del itinerario.\nError: {ex.Message}");
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                        LeerFilas.Close();
                    }
                    return eventos;
                }
            }
        }

    }
}
