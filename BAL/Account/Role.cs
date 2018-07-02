using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Account
{
    public class Role
    {
        public Int32 RoleId { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }


        public string insertRole(Role role)
        {
            return Common.putData(role, "sp_Role");
        }

        public string UpdateRole(Role role)
        {
            return Common.putData(role, "sp_Role");
        }

        public string DeleteRole(Role role)
        {
            return Common.putData(role, "sp_Role");
        }


        public DataSet getRole(Int32 RoleId)
        {
            this.RoleId = RoleId;
            this.cmd = "getRole";
            fillRoleInfo(Common.getData(this, "sp_Role"));
            return this;
        }

        public DataSet getAllRole()
        {
            this.cmd = "getAllRole";
            return Common.getData(this, "sp_Role");
        }

        public DataSet getAllRoleCmb()
        {
            this.cmd = "getAllRoleCmb";
            return Common.getData(this, "sp_Role");
        }

        private Role fillRoleInfo(DataSet ds)
        {
            if (!Common.isDataSetEmpty(ds))
            {
                this.RoleId = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleId"]);
                this.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
            }
            return this;
        }
    }
}
