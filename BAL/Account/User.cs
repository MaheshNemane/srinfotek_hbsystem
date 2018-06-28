using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Account
{
   public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }
        public string Status { get; set; }

        public string cmd { get; set; }

        public string insertUser(User user)
        {
            return Common.putData(user, "sp_User");
        }


        public DataSet getUser()
        {
            this.cmd = "getUser";
            return Common.getData(this, "sp_User");
        }

        public DataSet getLogin(string UserName)
        {
            this.cmd = "getLogin";
            this.UserName = UserName;
            return Common.getData(this, "sp_User");
        }


        public DataSet getAllUser()
        {
            this.cmd = "getAllUser";
            return Common.getData(this, "sp_User");
        }
    }
}
