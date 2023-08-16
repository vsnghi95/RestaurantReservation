using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Food
    {
        public int Fid { get; set; }
        public string Fname { get; set; }
        public decimal? Price { get; set; }
        public int? Cateid { get; set; }

        public virtual FoodCategory Cate { get; set; }
    }
}
