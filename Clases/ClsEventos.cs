using Administración_Centro_de_Convenciones.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
