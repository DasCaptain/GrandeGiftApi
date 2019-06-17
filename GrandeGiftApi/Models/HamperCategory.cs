using System;
using System.Collections.Generic;

namespace GrandeGiftApi.Models
{
    public partial class HamperCategory
    {
        public HamperCategory()
        {
            Hampers = new HashSet<Hampers>();
        }

        public int Id { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<Hampers> Hampers { get; set; }
    }
}
