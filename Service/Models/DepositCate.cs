using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class DepositCate
    {
        public DepositCate()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int DepositId { get; set; }
        public string DepositName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
