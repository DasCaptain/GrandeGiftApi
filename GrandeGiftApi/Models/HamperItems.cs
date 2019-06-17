using System;
using System.Collections.Generic;

namespace GrandeGiftApi.Models
{
    public partial class HamperItems
    {
        public int HamperId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public virtual Hampers Hamper { get; set; }
        public virtual Products Product { get; set; }
    }
}
