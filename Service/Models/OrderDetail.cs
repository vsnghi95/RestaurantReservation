using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class OrderDetail
    {
        public int? Odid { get; set; }
        public int? Fid { get; set; }
        public int? Quantity { get; set; }
        public decimal? AmountOfFood { get; set; }

        public virtual Food FidNavigation { get; set; }
        public virtual Order Od { get; set; }
    }
}
