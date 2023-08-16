using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class TablesRe
    {
        public TablesRe()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Tid { get; set; }
        public string TableName { get; set; }
        public int? Capacity { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
