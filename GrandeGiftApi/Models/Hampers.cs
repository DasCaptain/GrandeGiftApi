using System;
using System.Collections.Generic;

namespace GrandeGiftApi.Models
{
    public partial class Hampers
    {
        public Hampers()
        {
            HamperItems = new HashSet<HamperItems>();
        }

        public int Id { get; set; }
        public string HamperName { get; set; }
        public decimal Price { get; set; }
        public int? HamperCategoryId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public virtual HamperCategory HamperCategory { get; set; }
        public virtual HamperImages HamperImages { get; set; }
        public virtual ICollection<HamperItems> HamperItems { get; set; }
    }
}
