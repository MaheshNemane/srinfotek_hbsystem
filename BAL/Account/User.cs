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
        public string UpdateUser(User user)
        {
            return Common.putData(user, "sp_User");
        }
        public string DeleteUser(User user)
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
            fillUserInfo(Common.getData(this, "sp_User"));
            return this;
        }


        public DataSet getAllUser()
        {
            this.cmd = "getAllUser";
            return Common.getData(this, "sp_User");
        }

        private User fillUserInfo(DataSet ds)
        {
            if (!Common.isDataSetEmpty(ds))
            {
                this.UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["UserId"]);
                this.RoleId = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleId"]);
                this.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                this.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                this.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                this.EmailId = ds.Tables[0].Rows[0]["EmailId"].ToString();
                this.MobileNo = ds.Tables[0].Rows[0]["MobileNo"].ToString();
                this.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                this.PasswordHint = ds.Tables[0].Rows[0]["PasswordHint"].ToString();
                this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
            }
            return this;
        }
    }
}
