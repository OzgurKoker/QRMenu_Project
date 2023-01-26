using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Kategori
    {
        public Kategori()
        {
            Uruns = new HashSet<Urun>();
        }

        public int Id { get; set; }
        public string? KategoriAdi { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
