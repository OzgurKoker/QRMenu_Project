using System;
using System.Collections.Generic;

namespace Proje.Models.Entities
{
    public partial class Urun
    {
        public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public string? UrunAciklama { get; set; }
        public string? UrunFiyat { get; set; }
        public int? UrunKategoriId { get; set; }

        public virtual Kategori? UrunKategori { get; set; }
    }
}
