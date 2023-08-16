using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
