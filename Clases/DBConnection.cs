using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Clases {
    public  class DBConnection {
        private readonly string connectionString;
        static string server = "MSI\\SQLEXPRESS";
        static string user = "database";
        static string password = "admin12345";
        public DBConnection() {
            connectionString = "Server="+ server+";"+ "DataBase=CentroConvenciones; user id="+user+";" + "password="+password+";";

        }
        public SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
    }
}
