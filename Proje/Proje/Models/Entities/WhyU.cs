using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class WhyU
    {
        public int Id { get; set; }
        public string? Sayi { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
    }
}
