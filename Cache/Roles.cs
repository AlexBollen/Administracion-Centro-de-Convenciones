using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_Centro_de_Convenciones.Cache
{
    public struct Roles
    {
        public const int administrador = 1;
        public const int digitador = 2;
        public const int supervisor = 3;
        public const int director = 4;
    }
}
