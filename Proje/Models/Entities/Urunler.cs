using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public string? UrunAdi { get; set; }
        public string? UrunFiyati { get; set; }
        public string? UrunAciklama { get; set; }
        public int? UrunKategoriId { get; set; }

        public virtual Kategoriler? UrunKategori { get; set; }
    }
}
