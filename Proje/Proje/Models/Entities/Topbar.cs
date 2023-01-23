using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Topbar
    {
        public int Id { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? Adres { get; set; }
        public string? Saat { get; set; }
    }
}
