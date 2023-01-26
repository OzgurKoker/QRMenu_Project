using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class SpecialsNav
    {
        public SpecialsNav()
        {
            Specials = new HashSet<Special>();
        }

        public int Id { get; set; }
        public string? Baslik { get; set; }
        public string? Href { get; set; }
        public string? Active { get; set; }

        public virtual ICollection<Special> Specials { get; set; }
    }
}
