using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class ReserveDetail
    {
        public int? Rid { get; set; }
        public int? Tid { get; set; }

        public virtual Reservation RidNavigation { get; set; }
        public virtual TablesRe TidNavigation { get; set; }
    }
}
