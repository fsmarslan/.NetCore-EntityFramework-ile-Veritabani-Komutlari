using Microsoft.EntityFrameworkCore;

namespace entity
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz\nVeri Ekle=1\nVeri Sil=2\nVeri Güncelle=3\nVeri Listele=4\nVeri Filtrele=5\nÇıkış=6");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    VeriEkle();
                }
                else if (secim == 2)
                {
                    VeriSilme();
                }
                else if (secim == 3)
                {
                    VeriGuncelle();
                }
                else if (secim == 4)
                {
                    VeriListele();
                }
                else if (secim == 5)
                {
                    VeriIdFiltrele();
                }
                else if (secim == 6)
                {
                    break;
                }
                else
                    Console.WriteLine("Hatalı tuşlama yaptınız...");
            }
        }

        static void VeriEkle()
        {
            using (var db = new EgitimContext())
            {
                while (true)
                {
                    Console.WriteLine("Hangi tabloya veri eklemek istiyorsunuz\nEgitmen-1\nKurs-2\nOgrenci-3\nPersonel-4\nSinif-5\nÇıkış-6");
                    int tabloNo = Convert.ToInt32(Console.ReadLine());

                    if (tabloNo == 1)
                    {
                        while (true)
                        {
                            Console.WriteLine("Eğitmen adını giriniz: ");
                            string ad = Console.ReadLine();
                            Console.WriteLine("Egitmen soyadı giriniz: ");
                            string soyAd = Console.ReadLine();
                            Console.WriteLine("Eğitmen yaşı giriniz: ");
                            int yas = Convert.ToInt32(Console.ReadLine());

                            var e = new Egitmen()
                            {
                                egitmenAd=ad,egitmenSoyad=soyAd,egitmenYas=yas
                            };
                            db.AddRange(e);
                            db.SaveChanges();
                            Console.WriteLine("Veriler Eklendi!");

                            Console.WriteLine("Veri eklemeye devam etmek istiyor musunuz?(Evet-1/Hayır-2)");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim==1)
                            {
                                Console.WriteLine("Veri eklemeye devam edebilirsiniz.");
                            }
                            else if (secim == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("yanlış tuşlama yaptınız");
                                break;
                            }
                        }   
                            
                        
                        
                    }

                    else if (tabloNo == 2)
                    {
                        while (true)
                        {
                            Console.WriteLine("Kurs adını giriniz: ");
                            string ad = Console.ReadLine();

                            var k = new Kurs()
                            {
                                kursAd=ad
                            };
                            db.AddRange(k);
                            db.SaveChanges();
                            Console.WriteLine("Veriler Eklendi!");

                            Console.WriteLine("Veri eklemeye devam etmek istiyor musunuz?(Evet-1/Hayır-2)");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                Console.WriteLine("Veri eklemeye devam edebilirsiniz.");
                            }
                            else if (secim == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("yanlış tuşlama yaptınız");
                                break;
                            }
                        }
                    }

                    else if (tabloNo == 3)
                    {
                        while (true)
                        {
                            Console.WriteLine("Öğrenci adını giriniz: ");
                            string ad = Console.ReadLine();
                            Console.WriteLine("Öğrenci soyadını giriniz: ");
                            string soyAd=Console.ReadLine();

                            var o = new Ogrenci()
                            {
                                ogrenciAd = ad,ogrenciSoyad=soyAd
                            };
                            db.AddRange(o);
                            db.SaveChanges();
                            Console.WriteLine("Veriler Eklendi!");

                            Console.WriteLine("Veri eklemeye devam etmek istiyor musunuz?(Evet-1/Hayır-2)");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                Console.WriteLine("Veri eklemeye devam edebilirsiniz.");
                            }
                            else if (secim == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("yanlış tuşlama yaptınız");
                                break;
                            }
                        }
                    }

                    else if (tabloNo == 4)
                    {
                        while (true)
                        {
                            Console.WriteLine("Personel adını giriniz: ");
                            string ad = Console.ReadLine();
                            Console.WriteLine("Personel soyadını giriniz: ");
                            string soyAd = Console.ReadLine();

                            var p = new Personel()
                            {
                                perAd = ad,
                                perSoyad = soyAd
                            };
                            db.AddRange(p);
                            db.SaveChanges();
                            Console.WriteLine("Veriler Eklendi!");

                            Console.WriteLine("Veri eklemeye devam etmek istiyor musunuz?(Evet-1/Hayır-2)");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                Console.WriteLine("Veri eklemeye devam edebilirsiniz.");
                            }
                            else if (secim == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("yanlış tuşlama yaptınız");
                                break;
                            }
                        }
                    }

                    else if (tabloNo == 5)
                    {
                        while (true)
                        {
                            Console.WriteLine("Sınıf no giriniz: ");
                            string no = Console.ReadLine();
                            

                            var s = new Sinif()
                            {
                                sinifNo = no
                            };
                            db.AddRange(s);
                            db.SaveChanges();
                            Console.WriteLine("Veriler Eklendi!");

                            Console.WriteLine("Veri eklemeye devam etmek istiyor musunuz?(Evet-1/Hayır-2)");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                Console.WriteLine("Veri eklemeye devam edebilirsiniz.");
                            }
                            else if (secim == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("yanlış tuşlama yaptınız");
                                break;
                            }
                        }
                    }

                    else if (tabloNo==6)
                    {
                        break;
                    }
                }
                    
            }
        }

        static void VeriSilme()
        {
            using (var db = new EgitimContext())
            {
                while (true)
                {
                    Console.WriteLine("Hangi tablodan veri silmek istiyorsunuz \nEgitmen-1\nKurs-2\nOgrenci-3\nPersonel-4\nSinif-5\nÇıkış-6");

                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        Console.WriteLine("Eğitmen Id giriniz: ");
                        int egitmenId = Convert.ToInt32(Console.ReadLine());
                        var egitmen = db.egitmenler.Find(egitmenId);
                        if (egitmen != null)
                        {
                            db.egitmenler.Remove(egitmen);
                            db.SaveChanges();
                            Console.WriteLine("Veri Silindi!");
                        }
                    }

                    else if (secim == 2)
                    {
                        Console.WriteLine("Kurs Id giriniz: ");
                        int kursId = Convert.ToInt32(Console.ReadLine());
                        var kurs = db.kurslar.Find(kursId);
                        if (kurs != null)
                        {
                            db.kurslar.Remove(kurs);
                            db.SaveChanges();
                            Console.WriteLine("Veri Silindi!");
                        }
                    }

                    else if (secim == 3)
                    {
                        Console.WriteLine("Öğrenci Id giriniz: ");
                        int ogrenciId = Convert.ToInt32(Console.ReadLine());
                        var ogrenci = db.ogrenciler.Find(ogrenciId);
                        if (ogrenci != null)
                        {
                            db.ogrenciler.Remove(ogrenci);
                            db.SaveChanges();
                            Console.WriteLine("Veri Silindi!");
                        }
                    }

                    else if (secim == 4)
                    {
                        Console.WriteLine("Personel Id giriniz: ");
                        int perId = Convert.ToInt32(Console.ReadLine());
                        var personel = db.personeller.Find(perId);
                        if (personel != null)
                        {
                            db.personeller.Remove(personel);
                            db.SaveChanges();
                            Console.WriteLine("Veri Silindi!");
                        }
                    }

                    else if (secim == 5)
                    {
                        Console.WriteLine("Sınıf Id giriniz: ");
                        int sinifId = Convert.ToInt32(Console.ReadLine());
                        var sinif = db.siniflar.Find(sinifId);
                        if (sinif != null)
                        {
                            db.siniflar.Remove(sinif);
                            db.SaveChanges();
                            Console.WriteLine("Veri Silindi!");
                        }
                    }

                    else if (secim == 6)
                    {
                        break;
                    }

                    else
                        Console.WriteLine("Yanlış Tuşlama Yaptınız...");
                }
            }
        }

        static void VeriGuncelle()
        {
            using (var context = new EgitimContext())
            {
                while (true)
                {
                    Console.WriteLine("Hangi tabloyu güncellemek istiyorsunuz\nEgitmen-1\nKurs-2\nOgrenci-3\nPersonel-4\nSinif-5\nÇıkış-6");
                    int secim=Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        while (true)
                        {
                            Console.WriteLine("Hangi sütunu güncellemek istiyorsunuz\nEğitmen ad-1\nEğitmen Soyad-2\nEğitmen Yas-3\nÇıkış-4");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Eğitmen ıd sini giriniz: ");
                            int secimId=Convert.ToInt32(Console.ReadLine());


                            if (secim2 == 1)
                            {
                                var update = context.egitmenler.Where(e => e.egitmenId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir isim giriniz");
                                string egitmenAd = (Console.ReadLine());
                                update.egitmenAd = egitmenAd;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 2)
                            {
                                var update = context.egitmenler.Where(e => e.egitmenId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir soyisim giriniz");
                                string egitmenSoyad = (Console.ReadLine());
                                update.egitmenSoyad = egitmenSoyad;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 3)
                            {
                                var update = context.egitmenler.Where(e => e.egitmenId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir yaş giriniz");
                                int egitmenYas = Convert.ToInt32(Console.ReadLine());
                                update.egitmenYas = egitmenYas;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 4)
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Hatalı tuşlama yaptınız...");
                        }
                    }
                    else if (secim == 2)
                    {
                        while (true)
                        {
                            Console.WriteLine("Kurs ıd sini giriniz:  ");
                            int secimId = Convert.ToInt32(Console.ReadLine());

                                var update = context.kurslar.Where(k => k.kursId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir isim giriniz");
                                string kursAd = (Console.ReadLine());
                                update.kursAd = kursAd;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                        }
                    }
                    else if (secim == 3)
                    {
                        while (true)
                        {
                            Console.WriteLine("Öğrenci ıd sini giriniz: ");
                            int secimId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Hangi sütunu güncellemek istiyorsunuz\nÖğrenci ad-1\nÖğrenci Soyad-2\nÇıkış-4");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                                var update = context.ogrenciler.Where(o => o.ogrenciId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir isim giriniz");
                                string ogrenciAd = (Console.ReadLine());
                                update.ogrenciAd = ogrenciAd;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 2)
                            {
                                var update = context.ogrenciler.Where(o => o.ogrenciId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir soyisim giriniz");
                                string ogrenciSoyad = (Console.ReadLine());
                                update.ogrenciSoyad = ogrenciSoyad;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 4)
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Hatalı tuşlama yaptınız...");
                        }
                    }
                    else if (secim == 4)
                    {
                        while (true)
                        {
                            Console.WriteLine("Personel ıd sini giriniz: ");
                            int secimId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Hangi sütunu güncellemek istiyorsunuz\nPersonel ad-1\nPersonel Soyad-2\nÇıkış-4");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                                var update = context.personeller.Where(p => p.perId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir isim giriniz");
                                string perAd = (Console.ReadLine());
                                update.perAd = perAd;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 2)
                            {
                                var update = context.personeller.Where(p => p.perId == secimId).FirstOrDefault();

                                Console.WriteLine("Bir soyisim giriniz");
                                string perSoyad = (Console.ReadLine());
                                update.perSoyad = perSoyad;
                                context.SaveChanges();
                                Console.WriteLine("Veri güncellendi!");
                            }
                            else if (secim2 == 4)
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Hatalı tuşlama yaptınız...");
                        }
                    }
                    else if (secim == 5)
                    {
                        while (true)
                        {
                            Console.WriteLine("Sınıf ıd sini giriniz:  ");
                            int secimId = Convert.ToInt32(Console.ReadLine());

                            var update = context.siniflar.Where(s => s.sinifId == secimId).FirstOrDefault();

                            Console.WriteLine("Sınıf no giriniz");
                            string sinifNo = (Console.ReadLine());
                            update.sinifNo = sinifNo;
                            context.SaveChanges();
                            Console.WriteLine("Veri güncellendi!");
                        }
                    }
                    else if(secim == 6) 
                    {
                        break;
                    }
                }
            }
        }

        static void VeriListele()
        {
            using (var context = new EgitimContext())
            {
                while(true)
                {
                    Console.WriteLine("Hangi tabloyu listelemek istiyorsunuz: \nEğitmen-1\nKurs-2\nÖğrenci-3\nPersonel-4\nSınıf-5\nÇıkış6");
                    int secim=Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        var egitmen = context.egitmenler.ToList();

                        foreach (var e in egitmen)
                        {
                            Console.WriteLine($"Ad: {e.egitmenAd} Soyad: {e.egitmenSoyad} Yaş: {e.egitmenYas}");
                        }
                    }
                    else if (secim == 2)
                    {
                        var kurs = context.kurslar.ToList();

                        foreach (var k in kurs)
                        {
                            Console.WriteLine($"Kurs Ad: {k.kursAd}");
                        }
                    }
                    else if (secim == 3)
                    {
                        var ogrenci = context.ogrenciler.ToList();

                        foreach (var o in ogrenci)
                        {
                            Console.WriteLine($"Öğrenci Ad: {o.ogrenciAd} Öğrenci Soyad: {o.ogrenciSoyad}");
                        }
                    }
                    else if (secim == 4)
                    {
                        var personel = context.personeller.ToList();

                        foreach (var p in personel)
                        {
                            Console.WriteLine($"Personel Ad: {p.perAd} Personel Soyad: {p.perSoyad}");
                        }
                    }
                    else if (secim == 5)
                    {
                        var sinif = context.siniflar.ToList();

                        foreach (var s in sinif)
                        {
                            Console.WriteLine($"Sınıf No: {s.sinifNo}");
                        }
                    }
                    else if (secim == 6)
                    {
                        break;
                    }
                    else
                        Console.WriteLine("Hatalı tuşlama yaptınız...");
                }
            }
        }

        static void VeriIdFiltrele()
        {
            using (var context = new EgitimContext())
            {
                while (true)
                {
                    Console.WriteLine("Hangi tabloyu getirmek istiyorsunuz: \nEğitmen-1\nKurs-2\nÖğrenci-3\nPersonel-4\nSınıf-5\nÇıkış-6");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        Console.WriteLine("Id giriniz: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var egitmen = context.egitmenler.Where(e => e.egitmenId == id).FirstOrDefault();

                        Console.WriteLine($"Ad: {egitmen.egitmenAd}, Soyad: {egitmen.egitmenSoyad}, Yaş: {egitmen.egitmenYas}");
                    }

                    else if (secim == 2)
                    {
                        Console.WriteLine("Id giriniz: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var kurs = context.kurslar.Where(k => k.kursId == id).FirstOrDefault();

                        Console.WriteLine($"Ad: {kurs.kursAd}");
                    }

                    else if (secim == 3)
                    {
                        Console.WriteLine("Id giriniz: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var ogrenci = context.ogrenciler.Where(o => o.ogrenciId == id).FirstOrDefault();

                        Console.WriteLine($"Ad: {ogrenci.ogrenciAd}, Soyad: {ogrenci.ogrenciSoyad}");
                    }

                    else if (secim == 4)
                    {
                        Console.WriteLine("Id giriniz: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var personel = context.personeller.Where(p => p.perId == id).FirstOrDefault();

                        Console.WriteLine($"Ad: {personel.perAd}, Soyad: {personel.perSoyad}");
                    }

                    else if (secim == 5)
                    {
                        Console.WriteLine("Id giriniz: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var sinif = context.siniflar.Where(s => s.sinifId == id).FirstOrDefault();

                        Console.WriteLine($"Sınıf No: {sinif.sinifNo}");
                    }

                    else if (secim == 6)
                    {
                        break;
                    }

                    else 
                        Console.WriteLine("Hatalı tuşlama yaptınız...");
                }
            }
        }
    }
}