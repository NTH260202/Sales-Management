﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public partial class TblOrder
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }

        public virtual TblMember Member { get; set; } = null!;
        public virtual TblOrderDetail TblOrderDetail { get; set; } = null!;
    }
}
