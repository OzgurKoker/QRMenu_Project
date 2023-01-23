using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class ContactForm
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Konu { get; set; }
        public string? Mesaj { get; set; }
    }
}
