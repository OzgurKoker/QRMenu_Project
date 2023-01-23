using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Footer
    {
        public int Id { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public string Icon1 { get; set; } = null!;
        public string? Icon1Link { get; set; }
        public string? Icon2 { get; set; }
        public string? Icon2Link { get; set; }
        public string? Icon3 { get; set; }
        public string? Icon3Link { get; set; }
        public string? Icon4 { get; set; }
        public string? Icon4Link { get; set; }
        public string? Icon5 { get; set; }
        public string? Icon5Link { get; set; }
    }
}
