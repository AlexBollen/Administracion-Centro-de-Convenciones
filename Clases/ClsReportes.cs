using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
