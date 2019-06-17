using System;
using System.Collections.Generic;

namespace GrandeGiftApi.Models
{
    public partial class HamperImages
    {
        public int Id { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public byte[] ImgContent { get; set; }
        public long ImgSize { get; set; }
        public int HamperId { get; set; }

        public virtual Hampers Hamper { get; set; }
    }
}
