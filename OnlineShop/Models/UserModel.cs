using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserModel
    {
        private OnlineShopDBContent context = null;

        public UserModel()
        {
            context = new OnlineShopDBContent();
        }
        public bool Login(string UserName, string Password)
        {
            var res = context.Database.SqlQuery<bool>("");
        }
    }
}
