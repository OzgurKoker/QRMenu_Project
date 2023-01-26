using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Slider
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public string? Hidden { get; set; }
    }
}
