using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases
{
    internal class ClsOrganizadores : DBConnection
    {
        private SqlDataReader LeerFilas;
        public DataTable ListarOrganizadores()
        {
            DataTable tablaOrganizadores = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
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
        public void InsertarOrganizador(
            bool estado,
            int IdPersona
        )
        {
            int idItinerario;
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertarOrganizadores";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@IdPersona", IdPersona);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al registrar el itinerario. \nError: {ex.Message}");
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public int InsertarPersona(
            string NombrePersona
        )
        {
            int idPersona;
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al registrar la persona. \nError: {ex.Message}");
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
