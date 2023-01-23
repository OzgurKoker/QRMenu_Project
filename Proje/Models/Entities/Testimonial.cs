using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Testimonial
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
    }
}
