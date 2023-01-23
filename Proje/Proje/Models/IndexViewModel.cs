

using Proje.Models.Entities;

namespace Proje.Models
{
    public class IndexViewModel
    {
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<BookTable> BookTables { get; set; }

        public IEnumerable<Chef> Chefs { get; set; }

        public IEnumerable<ContactForm> ContactForms { get; set; }

        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Footer> Footers { get; set; }

        public IEnumerable<Gallery> Gallerys { get; set; }

        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Special> Specials { get; set; }

        public IEnumerable<Title> Titles { get; set; }
        public IEnumerable<Topbar> Topbars { get; set; }

        public IEnumerable<WhyU> WhyUs { get; set; }

        public IEnumerable<SpecialsNav> SpecialsNavs { get; set; }

        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Urun> Uruns { get; set; }

        public IEnumerable<Kategori> Kategoris { get; set; }

    }
}
