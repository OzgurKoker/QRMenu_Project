using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            Urunlers = new HashSet<Urunler>();
        }

        public int KategoriId { get; set; }
        public string? KategoriAd { get; set; }

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
