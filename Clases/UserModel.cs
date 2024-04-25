using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administración_Centro_de_Convenciones.Clases {
    internal class UserModel {
        UserData userData = new UserData();
        public bool LoginUser(string user, string pass) {
            return userData.Login(user, pass);
        }
    }
}
