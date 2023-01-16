using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class BookTable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Datetime { get; set; }
        public int? Person { get; set; }
        public string? Aciklama { get; set; }
    }
}
