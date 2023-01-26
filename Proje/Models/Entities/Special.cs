using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Special
    {
        public int Id { get; set; }
        public string? Href { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Image { get; set; }
        public string? Active { get; set; }
        public int? SpecialsNavId { get; set; }

        public virtual SpecialsNav? SpecialsNav { get; set; }
    }
}
