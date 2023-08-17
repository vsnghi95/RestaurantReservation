using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            Orders = new HashSet<Order>();
        }

        public int Rid { get; set; }
        public int? Oid { get; set; }
        public int? Cid { get; set; }
        public int? Aid { get; set; }
        public DateTime? ResDate { get; set; }
        public int? NumGuest { get; set; }
        public int? DepositType { get; set; }
        public decimal? DepositValue { get; set; }

        public virtual Account AidNavigation { get; set; }
        public virtual Customer CidNavigation { get; set; }
        public virtual DepositCate DepositTypeNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
