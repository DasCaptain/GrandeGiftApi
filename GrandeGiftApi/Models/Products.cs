using System;
using System.Collections.Generic;

namespace GrandeGiftApi.Models
{
    public partial class Products
    {
        public Products()
        {
            HamperItems = new HashSet<HamperItems>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<HamperItems> HamperItems { get; set; }
    }
}
