using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Cid { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
