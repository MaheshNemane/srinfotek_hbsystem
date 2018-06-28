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
        public Int64 RoleId { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }


        public string insertRole(Role role)
        {
            return Common.putData(role, "sp_Role");
        }

        public DataSet getRole(Int64 RoleId)
        {
            this.RoleId = RoleId;
            this.cmd = "getRole";
            return Common.getData(this, "sp_Role");
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
    }
}
