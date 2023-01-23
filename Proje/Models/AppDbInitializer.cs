using Proje.Models.Entities;

namespace Proje.Models
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ProjeContext>();
                context.Database.EnsureCreated();

                if (!context.Abouts.Any())
                {
                    context.Abouts.AddRange(new List<About>()
                    {
                        new About()
                        {
                            Image="about.jpg",
                            YoutubeLink="https://www.youtube.com/watch?v=jDDaplaOz7Q",
                            Baslik="um ipsam laborum deleniti velit pariatur architecto aut nihil",
                            Aciklama1=" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et magna aliqua.",
                            Aciklama2="  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et magna aliqua.",
                            Madde1="Dauis aute irure dolor in reprehenderit in voluptate velit.",
                            Madde2="Duis aute irure dolor in reprehenderit in voluptate velit.",
                            Madde3="Duis aute irure dolor in reprehenderit in voluptate velit.",
                            Aciklama3="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et  magna aliqua.",
                        },

                    });
                    context.SaveChanges();
                }

                if (!context.Chefs.Any())
                {
                    context.Chefs.AddRange(new List<Chef>()
                    {
                        new Chef()
                        {
                        Image="chefs-1.jpg",
                           Name="Walter Whiteaı",
                           Title="Master Chefa",
                           Twitter="#",
                           Facebook="#",
                           Instagram="#",
                           Linkedin="#"
                        },
                       new Chef()
                        {
                           Image="chefs-2.jpg",
                           Name="Sarah Jhonson",
                           Title="Patissier",
                           Twitter="#",
                           Facebook="#",
                           Instagram="#",
                           Linkedin="#"
                        },
                           new Chef()
                        {
                           Image="chefs-3.jpg",
                           Name="William Anderson",
                           Title="Patissier",
                           Twitter="#",
                           Facebook="#",
                           Instagram="#",
                           Linkedin="#"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Events.Any())
                {
                    context.Events.AddRange(new List<Event>()
                    {
                        new Event()
                        {
                        Image="event-birthday.jpg",
                        Baslik="Custom Parties",
                        Fiyat="10",
                        Aciklama1=" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et magna aliqua.",
                        Madde1="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                      Madde2="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                         Madde3="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                         Aciklama2="   Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in velit esse cillum dolore eu f"
                        },
                            new Event()
                        {
                        Image="event-private.jpg",
                        Baslik="Private Parties",
                        Fiyat="210",
                        Aciklama1=" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et magna aliqua.",
                        Madde1="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                      Madde2="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                         Madde3="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                         Aciklama2="   Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in velit esse cillum dolore eu f"
                        },
                            new Event()
                        {
                        Image="event-custom.jpg",
                        Baslik="Custom Parties",
                        Fiyat="440",
                        Aciklama1=" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et magna aliqua.",
                        Madde1="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                      Madde2="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                         Madde3="Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                         Aciklama2="   Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in velit esse cillum dolore eu f"
                        },
                    });
                    context.SaveChanges();
                }


                if (!context.Footers.Any())
                {
                    context.Footers.AddRange(new List<Footer>()
                    {
                        new Footer()
                        {
                     Baslik="Delicious",
                     Aciklama="Et aut eum quis fuga eos sunt ipsa nihil. Labore corporis magni eligendi fuga maxime saepe commodi placeat.",
                     Icon1="twitter",
                     Icon1Link="#",
                            Icon2="facebook",
                     Icon2Link="#",
                            Icon3="instagram",
                     Icon3Link="#",
                            Icon4="google",
                     Icon4Link="#",
                            Icon5="linkedin",
                     Icon5Link="#"

                        },

                    });
                    context.SaveChanges();
                }


                if (!context.Galleries.Any())
                {
                    context.Galleries.AddRange(new List<Gallery>()
                    {
                        new Gallery()
                        {
                            Image="gallery-1.jpg"

                        },
                        new Gallery()
                        {
                            Image="gallery-2.jpg"

                        },
                      new Gallery()
                        {
                            Image="gallery-3.jpg"

                        },
                       new Gallery()
                        {
                            Image="gallery-4.jpg"

                        },
                        new Gallery()
                        {
                            Image="gallery-5.jpg"

                        },
             new Gallery()
                        {
                            Image="gallery-6.jpg"

                        },
             new Gallery()
                        {
                            Image="gallery-7.jpg"

                        },
             new Gallery()
                        {
                            Image="gallery-8.jpg"

                        },
                    });
                    context.SaveChanges();
                }




                if (!context.Logins.Any())
                {
                    context.Logins.AddRange(new List<Login>()
                    {
                        new Login()
                        {
                            Username="admin",
                            Password="123"

                        },

                    });
                    context.SaveChanges();
                }


                if (!context.Sliders.Any())
                {
                    context.Sliders.AddRange(new List<Slider>()
                    {
                        new Slider()
                        {
                            Image="slide-1.jpg",
                            Baslik="Delicious Restaurant",
                            Aciklama="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto."

                        },
                          new Slider()
                        {
                            Image="slide-2.jpg",
                            Baslik="Lorem Ipsum Dolov",
                            Aciklama="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto."

                        },
                                 new Slider()
                        {
                            Image="slide-3.jpg",
                            Baslik="Sequi ea ut et est quaerat",
                            Aciklama="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto."

                        },


                    });
                    context.SaveChanges();
                }
                if (!context.SpecialsNavs.Any())
                {
                    context.SpecialsNavs.AddRange(new List<SpecialsNav>()
                    {
                        new SpecialsNav()
                        {
                           Baslik="Modi sit est",
                           Href="tab-1",
                           Active="active show"
                        },
                  new SpecialsNav()
                        {
                           Baslik="asdUnde praesentium sed",
                           Href="tab-2",
                           Active=" "
                        },
                      new SpecialsNav()
                        {
                           Baslik="Pariatur explicabo vel",
                           Href="tab-3",
                           Active=" "
                        },
                        new SpecialsNav()
                        {
                           Baslik="Nostrum qui quasi",
                           Href="tab-4",
                           Active=" "
                        },
                           new SpecialsNav()
                        {
                           Baslik="aaIusto ut expedita aut",
                           Href="tab-5  ",
                           Active=" "
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Specials.Any())
                {
                    context.Specials.AddRange(new List<Special>()
                    {
                        new Special()
                        {
                           Href="tab-1",
                           Baslik="Architecto ut aperiam autem id",
                           Aciklama1="mnis blanditiis saepe eos autem qui sunt debitis porro quia.",
                           Aciklama2="aque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore",
                           Image="specials-1.jpg",
                           Active="active",
                           SpecialsNavId=1
                        },
                              new Special()
                        {
                           Href="tab-2",
                           Baslik="asdEt blanditiis nemo veritatis excepturi",
                           Aciklama1="asdOmnis blanditiis saepe eos autem qui sunt debitis porro quia.",
                           Aciklama2="aque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore",
                           Image="specials-2.jpg",
                           Active=" ",
                           SpecialsNavId=2
                        },
               new Special()
                        {
                           Href="tab-3",
                           Baslik="Impedit facilis occaecati odio neque aperiam sit",
                           Aciklama1="asdOmnis blanditiis saepe eos autem qui sunt debitis porro quia.",
                           Aciklama2="aque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore",
                           Image="specials-3.jpg",
                           Active=" ",
                           SpecialsNavId=3
                        },
                        new Special()
                        {
                           Href="tab-4",
                           Baslik="Fuga dolores inventore laborolore",
                           Aciklama1="asdOmnis blanditiis saepe eos autem qui sunt debitis porro quia.",
                           Aciklama2="aque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore",
                           Image="specials-4.jpg",
                           Active=" ",
                           SpecialsNavId=4
                        },
                                  new Special()
                        {
                           Href="tab-5",
                           Baslik="Est eveniet ipsam sindera pad rone mat",
                           Aciklama1="asdOmnis blanditiis saepe eos autem qui sunt debitis porro quia.",
                           Aciklama2="aque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore",
                           Image="specials-5.jpg",
                           Active=" ",
                           SpecialsNavId=5
                        },
                    });
                    context.SaveChanges();
                }



                if (!context.Testimonials.Any())
                {
                    context.Testimonials.AddRange(new List<Testimonial>()
                    {
                        new Testimonial()
                        {
                            Image="testimonials-1.jpg",
                            Name="Saul Goodmanığüğ",
                            Title="Ceo Founderığüğüğ",
                            Text=" quorum aliqua sint quem legam fore suyuooyuoyuyouyouoyuouyyouyooyoyuoyunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid"
                        },
                          new Testimonial()
                        {
                            Image="testimonials-2.jpg",
                            Name="Sara Wilsson",
                            Title="Jena Karlis",
                            Text=" quorum aliqua sint quem legam fore suyuooyuoyuyouyouoyuouyyouyooyoyuoyunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid"
                        },
                                  new Testimonial()
                        {
                            Image="testimonials-3.jpg",
                            Name="Jena Karlis",
                            Title="Store Owner",
                            Text=" quorum aliqua sint quem legam fore suyuooyuoyuyouyouoyuouyyouyooyoyuoyunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid"
                        },
                                                    new Testimonial()
                        {
                            Image="testimonials-4.jpg",
                            Name="Matt Brandon",
                            Title="Freelancer",
                            Text=" quorum aliqua sint quem legam fore suyuooyuoyuyouyouoyuouyyouyooyoyuoyunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid"
                        },
                                 new Testimonial()
                        {
                            Image="testimonials-5.jpg",
                            Name="John Larson",
                            Title="Entrepreneur",
                            Text=" quorum aliqua sint quem legam fore suyuooyuoyuyouyouoyuouyyouyooyoyuoyunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Titles.Any())
                {
                    context.Titles.AddRange(new List<Title>()
                    {
                        new Title()
                        {
                          WhyUsBaslik="neden biz çünkü neden olmasın",
                          WhyUsAciklama="Ut possimus qui ut temporibus culpa velit",
                          SpecialsBaslik="Check our Specials",
                          SpecialsAciklama="Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.",
                          GalleryBaslik="Some photos from Our Restaurant ",
                          GalleryAciklama="Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.",
                          ContactBaslik="Contact Us",
                          ContactAciklama="Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.",
                          ChefsBaslik="Delicious",
                          ChefsAciklama="Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.",
                          BooktableBaslik="Book a Table",
                          BooktableAciklama="Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.",
                          EventsBaslik="Merhaba bu bir deneme başlığıdır"
                        },

                    });
                    context.SaveChanges();
                }

                if (!context.Topbars.Any())
                {
                    context.Topbars.AddRange(new List<Topbar>()
                    {
                        new Topbar()
                        {
                        Telefon="0535 576 14 86",
                        Email="ozgur.koker17@gmail.com",
                        Adres="Eyüp Merkez, Feshane Cd. No:8, 34050 Eyüpsultan/İstanbul",
                        Saat="Pzt-Pzr11:00 - 23:00"
                        },

                    });
                    context.SaveChanges();
                }

                if (!context.WhyUs.Any())
                {
                    context.WhyUs.AddRange(new List<WhyU>()
                    {
                        new WhyU()
                        {
                     Sayi="01",
                     Baslik="Lorem Ipsum",
                     Aciklama="Ulamco laboris nisi ut aliquip ex ea commodo consequat. Et consectetur ducimus vero placeat"
                        },
                           new WhyU()
                        {
                     Sayi="02",
                     Baslik="Repellat Nihila",
                     Aciklama="Ulamco laboris nisi ut aliquip ex ea commodo consequat. Et consectetur ducimus vero placeat"
                        },
                                  new WhyU()
                        {
                     Sayi="03",
                     Baslik="Ad ad velit qui",
                     Aciklama="Ulamco laboris nisi ut aliquip ex ea commodo consequat. Et consectetur ducimus vero placeat"
                        },

                    });
                    context.SaveChanges();
                }

                if (!context.Kategoris.Any())
                {
                    context.Kategoris.AddRange(new List<Kategori>()
                    {
                        new Kategori()
                        {
                KategoriAdi="Sıcak İçecekler",
                        },
                  new Kategori()
                        {
                KategoriAdi="Soğuk İçecekler",
                        },
                       new Kategori()
                        {
                KategoriAdi="Tatlılar",
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Uruns.Any())
                {
                    context.Uruns.AddRange(new List<Urun>()
                    {
                        new Urun()
                        {
                         UrunAdi="çay",
                         UrunFiyat="5",
                         UrunAciklama="dfafda as sdsa fa dg sg g",
                         UrunKategoriId=1
                        },
                            new Urun()
                        {
                         UrunAdi="kahve",
                         UrunFiyat="56",
                         UrunAciklama="dfafda as sdsa fa dg sg g",
                         UrunKategoriId=1
                        },
                         new Urun()
                        {
                         UrunAdi="limonata",
                         UrunFiyat="55",
                         UrunAciklama="df afd a as sdsa fa dg sg g",
                         UrunKategoriId=2
                        },
                                new Urun()
                        {
                         UrunAdi="su",
                         UrunFiyat="2",
                         UrunAciklama="df afd a as sdsa fa dg sg g",
                         UrunKategoriId=2
                        },
                        new Urun()
                        {
                         UrunAdi="sütlaç",
                         UrunFiyat="536",
                         UrunAciklama="df afd a as sdsa fa dg sg g",
                         UrunKategoriId=3
                        },
                                new Urun()
                        {
                         UrunAdi="tiramisu",
                         UrunFiyat="35",
                         UrunAciklama="df afd a as sdsa fa dg sg g",
                         UrunKategoriId=3
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.ContactForms.Any())
                {
                    context.ContactForms.AddRange(new List<ContactForm>()
                    {
                        new ContactForm()
                        {
                        Konu="yemek",
                        Mesaj="cok kotu",
                        Email="ozgur.koker17@gmail.com",
                        Name="özgür"
                        },
                

                    });
                    context.SaveChanges();
                }



















            }
        }
    }
}
