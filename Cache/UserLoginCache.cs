using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Administración_Centro_de_Convenciones.Cache {
    public static class UserLoginCache {
        public static int IdUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Usuario { get; set; }
        public static int IdRol { get; set; }
        public static string NombreRol { get; set; }
        public static int IdDireccion { get; set; }
        public static int IdContacto { get; set; }
    }
}
