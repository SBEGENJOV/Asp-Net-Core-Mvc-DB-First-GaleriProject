using System;
using System.Collections.Generic;

namespace dbfirstcoreproject.Models
{
    public partial class Agalerisi
    {
        public int GaleriId { get; set; }
        public string? GaleriAd { get; set; }
        public decimal? Ciro { get; set; }
        public int? MalSayisi { get; set; }
        public string? Resim { get; set; }
    }
}
