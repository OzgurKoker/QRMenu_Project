using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Title
    {
        public int Id { get; set; }
        public string? WhyUsBaslik { get; set; }
        public string WhyUsAciklama { get; set; } = null!;
        public string? SpecialsBaslik { get; set; }
        public string? SpecialsAciklama { get; set; }
        public string? GalleryBaslik { get; set; }
        public string? GalleryAciklama { get; set; }
        public string? ContactBaslik { get; set; }
        public string? ContactAciklama { get; set; }
        public string? ChefsBaslik { get; set; }
        public string? ChefsAciklama { get; set; }
        public string? EventsBaslik { get; set; }
    }
}
