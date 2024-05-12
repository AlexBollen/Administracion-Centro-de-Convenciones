using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases
{
    internal class ClsTipoEvento : DBConnection
    {
        private SqlDataReader LeerFilas;
        public DataTable ListarTipoEventos()
        {
            DataTable tablaTipoEventos = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarTipoEvento";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    tablaTipoEventos.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return tablaTipoEventos;
                }
            }
        }
        public void InsertarTipoEvento(
            string NombreTipoEvento,
            string Descripción
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
                        command.CommandText = "InsertarTipoEvento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreTipoEvento", NombreTipoEvento);
                        command.Parameters.AddWithValue("@Descripcion", Descripción);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al registrar el tipo de evento. \nError: {ex.Message}");
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public string[] CargarRegistroTipoEvento(int IdTipoEvento)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM TipoEvento WHERE IdTipoEvento =" + IdTipoEvento;
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
        public void EditarTipoEvento(
            int IdTipoEvento,
            string NombreTipoEvento,
            string Descripcion
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
                        command.CommandText = "ActualizarTipoEvento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdTipoEvento", IdTipoEvento);
                        command.Parameters.AddWithValue("@NombreTipoEvento", NombreTipoEvento);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al actualizar el tipo de evento. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void EliminarTipoEvento(
            int IdTipoEvento
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
                        command.CommandText = "DELETE TipoEvento WHERE IdTipoEvento=" + IdTipoEvento;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al eliminar el tipo de evento. \nError: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
