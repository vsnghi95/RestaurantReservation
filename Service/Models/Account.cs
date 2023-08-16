using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Account
    {
        public Account()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Aid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public bool? Status { get; set; }

        public virtual Role RoleNavigation { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
