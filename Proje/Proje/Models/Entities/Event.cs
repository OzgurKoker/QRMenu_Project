using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Event
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Baslik { get; set; }
        public string? Fiyat { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Madde1 { get; set; }
        public string? Madde2 { get; set; }
        public string? Madde3 { get; set; }
        public string? Aciklama2 { get; set; }
    }
}
