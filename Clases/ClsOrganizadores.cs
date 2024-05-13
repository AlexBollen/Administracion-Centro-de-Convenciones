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
            string estado,
            int IdPersona
        )
        {            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertarOrganizadores";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EstadoOrganizador", estado);
                        command.Parameters.AddWithValue("@IdPersona", IdPersona);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al registrar el organizador. \nError: {ex.Message}");
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
        public string[] CargarRegistroOrganizador(int IdOrganizador)
        {
            List<string[]> listaRegistro = new List<string[]>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Organizador WHERE IdOrganizador=" + IdOrganizador;
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    string[] row = new string[LeerFilas.FieldCount];
                    try
                    {
                        if (LeerFilas.Read())
                        {
                            for (int i = 0; i < LeerFilas.FieldCount; i++)
                            {
                                row[i] = LeerFilas[i].ToString();
                            }
                            return row;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se encontro el registro.\nError: " + ex.Message);
                        throw;
                    }
                    finally
                    {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }
        public string[] CargarRegistroPersona(int IdPersona)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Persona WHERE IdPersona=" + IdPersona;
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    string[] row = new string[LeerFilas.FieldCount];
                    try
                    {
                        if (LeerFilas.Read())
                        {
                            for (int i = 0; i < LeerFilas.FieldCount; i++)
                            {
                                row[i] = LeerFilas[i].ToString();
                            }
                            return row;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se encontro el registro de la persona.\nError: {ex.Message}");
                        throw;
                    }
                    finally
                    {
                        LeerFilas.Close();
                        connection.Close();
                    }
                }
            }
        }
        public void EditarOrganizador(
            int IdOrganizador,
            string Estado,
            int IdPersona,
            string NombrePersona
        )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ActualizarOrganizador";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdOrganizador", IdOrganizador);
                        command.Parameters.AddWithValue("@EstadoOrganizador", Estado);
                        command.Parameters.AddWithValue("@IdPersona", IdPersona);
                        command.Parameters.AddWithValue("@NombrePersona", NombrePersona);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al actualizar el organizador. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void EliminarOrganizador(
            int IdOrganizador
        )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "DELETE Organizador WHERE IdOrganizador=" + IdOrganizador;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al eliminar el evento. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
