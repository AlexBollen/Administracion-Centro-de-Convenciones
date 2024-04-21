using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class DBConecction {
        SqlConnection connection = new SqlConnection();

        static string server="localhost";
        static string bd="CentroConvenciones";
        static string user="alexb";
        static string password="databasepass";
        static string port="1433";

        string connectionString = "Data Source=" + server + "," + port + ";" 
                                    + "user id=" + user + ";" + "password=" + password + ";" 
                                    + "Initial Catalog=" + bd + ";" 
                                    + "Persist Security Info=true";

        public SqlConnection stablishConnection() {
            try {
                connection.ConnectionString = connectionString;
                connection.Open();
            } catch (SqlException e) {
                MessageBox.Show("La conexión con la base de datos fallo\nError: " + e.ToString());
            }
            return connection;
        }
    }
}
