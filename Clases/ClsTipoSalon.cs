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
    internal class ClsTipoSalon : DBConnection
    {
        private SqlDataReader LeerFilas;
        public DataTable ListarTipoSalones()
        {
            DataTable tablaTipoSalones = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarTipoSalon";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaTipoSalones.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaTipoSalones;
                }
            }
        }
        public void InsertarTipoSalon(
            string NombreTipoSalon,
            int Existencias
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
                        command.CommandText = "InsertarTipoSalon";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreTipoSalon", NombreTipoSalon);
                        command.Parameters.AddWithValue("@ExistenciasTipoSalon", Existencias);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al registrar el tipo de salón. \nError: {ex.Message}");
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public string[] CargarRegistroTipoSalon(int IdTipoSalon)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM TipoSalon WHERE IdTipoSalon =" + IdTipoSalon;
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
        public void EditarTipoSalon(
            int IdTipoSalon,
            string NombreTipoSalon,
            int  Existencias
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
                        command.CommandText = "ActualizarTipoSalones";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdTipoSalon", IdTipoSalon);
                        command.Parameters.AddWithValue("@NombreTipoSalon", NombreTipoSalon);
                        command.Parameters.AddWithValue("@ExistenciasTipoSalon", Existencias);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al actualizar el tipo de salón. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void EliminarTipoSalon(
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
                        command.CommandText = "DELETE TipoSalon WHERE IdTipoSalon=" + IdTipoSalon;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al eliminar el tipo de salón. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
