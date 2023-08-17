using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class TablesRe
    {
        public int Tid { get; set; }
        public string TableName { get; set; }
        public int? Capacity { get; set; }
        public bool? Status { get; set; }
    }
}
