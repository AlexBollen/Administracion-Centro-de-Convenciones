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
                        command.CommandText = "InsertarSalon";
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
        public void EditarSalon(
            int IdSalon,
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
                        command.CommandText = "ActualizarSalones";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdSalon", IdSalon);
                        command.Parameters.AddWithValue("@NombreSalon", Nombre);
                        command.Parameters.AddWithValue("@EstadoSalon", Estado);
                        command.Parameters.AddWithValue("@Capacidad", capacidad);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@IdTipoSalon", IdTipoSalon);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al actualizar el usuario. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void EliminarSalon(
            int IdSalon
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
                        command.CommandText = "DELETE Salon WHERE IdSalon=" + IdSalon;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al eliminar el salón. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string[]  ObtenerExistenciasTipoSalon(int IdTipoSalon) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM TipoSalon WHERE IdTipoSalon =" + IdTipoSalon;
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

        public void ActualizarExistenciasTipoSalon(
            int IdTipoSalon, 
            int cantidadActualizada) {
            using (var connection = GetConnection()) {
                connection.Open();
                try {
                    using (var command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "ActualizarExistenciasTipoSalon";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdTipoSalon", IdTipoSalon);
                        command.Parameters.AddWithValue("@ExistenciasTipoSalon", cantidadActualizada);
                        command.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Ocurrio un error al actualizar el tipo de salon. \nError: {ex.Message}");
                } finally {
                    connection.Close();
                }
            }
        }
    }
}
