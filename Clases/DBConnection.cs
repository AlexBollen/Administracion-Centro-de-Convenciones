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
        static string server = "";
        static string user = "";
        static string password = "";
        public DBConnection() {
            connectionString = "Server="+ server+";"+ "DataBase=CentroConvenciones; user id="+user+";" + "password="+password+";";

        }
        public SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
    }
}
