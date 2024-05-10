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
    internal class ClsSalones : DBConnection
    {
        private SqlDataReader LeerFilas;
        public DataTable ListarSalones()
        {
            DataTable tablaSalones = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
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
        public DataTable ListarTipos()
        {
            DataTable tablaTiposSalon = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarTipoSalon";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaTiposSalon.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaTiposSalon;
                }
            }
        }
        public void InsertarSalon(
            string Nombre,
            string Estado,
            string descripcion,
            int capacidad,
            int IdTipoSalon
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
                        command.CommandText = "InsertarSalones";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreSalon", Nombre);
                        command.Parameters.AddWithValue("@EstadoSalon", Estado);
                        command.Parameters.AddWithValue("@Capacidad", capacidad);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@IdTipoSalon", IdTipoSalon);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al registrar el salón. \nError: {ex.Message}");
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public string[] CargarRegistroSalon(int IdSalon)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Salon WHERE IdSalon =" + IdSalon;
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
    }
}
