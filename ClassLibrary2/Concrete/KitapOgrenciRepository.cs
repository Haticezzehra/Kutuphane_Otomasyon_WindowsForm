using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer.Concrete
{
    public class KitapOgrenciRepository
    {
        public void Add(KitapOgrenci kitapOgrenci)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                context.KitapOgrenci.Add(kitapOgrenci);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                KitapOgrenci kitapOgrenci = context.KitapOgrenci.Where(n => n.ID == Id).First();

                context.KitapOgrenci.Remove(kitapOgrenci);
                context.SaveChanges();
            }
        }


        public GetModelKitapOgrenci GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var kitapOgrenci = context.KitapOgrenci.Where(n => n.ID == Id).First();
                GetModelKitapOgrenci kitapogrenci = new GetModelKitapOgrenci();
                kitapogrenci.AlisTarihi = Convert.ToDateTime(kitapOgrenci.AlisTarihi);
                kitapogrenci.DegisiklikTarihi = Convert.ToDateTime(kitapogrenci.DegisiklikTarihi);
                kitapogrenci.DegisiklikYapan = kitapOgrenci.DegisiklikYapan;
                kitapogrenci.ID = kitapOgrenci.ID;
                kitapogrenci.KayitYapan = kitapOgrenci.KayitYapan;
                kitapogrenci.KayitTarihi = Convert.ToDateTime(kitapOgrenci.KayıtTarihi);
                kitapogrenci.KitapID = kitapOgrenci.KitapID;
                kitapogrenci.kitapAdi = context.Kitap.Where(n => n.ID == kitapOgrenci.KitapID).First().Adi;
                kitapogrenci.KullaniciID = kitapOgrenci.KullaniciID;
                kitapogrenci.OgrenciID = kitapOgrenci.OgrenciID;
                kitapogrenci.OgrenciAdı = context.Ogrenci.Where(n => n.ID == kitapOgrenci.OgrenciID).First().AdSoyad;
                kitapogrenci.KullaniciAdi = context.Kullanici.Where(n => n.ID == kitapOgrenci.KullaniciID).First().KullaniciAdi;
                kitapogrenci.TeslimTarihi = Convert.ToDateTime(kitapOgrenci.TeslimTarihi);
                return kitapogrenci;
            }
        }

        public List<GetModelKitapOgrenci> GetAll()
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                List<GetModelKitapOgrenci> ogrenciList = new List<GetModelKitapOgrenci>();
                foreach (var i in context.KitapOgrenci.ToList())
                {
                    ogrenciList.Add(new GetModelKitapOgrenci()
                    {
                        ID = i.ID,
                        OgrenciID = i.OgrenciID,
                        OgrenciAdı = context.Ogrenci.Where(n => n.ID == i.OgrenciID).First().AdSoyad,
                        KitapID = i.KitapID,
                        kitapAdi = context.Kitap.Where(n => n.ID == i.KitapID).First().Adi,
                        KullaniciID = i.KullaniciID,
                        KullaniciAdi = context.Kullanici.Where(n => n.ID == i.KullaniciID).First().KullaniciAdi,
                        DegisiklikTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        KayitTarihi = Convert.ToDateTime(i.KayıtTarihi),
                        DegisiklikYapan = i.DegisiklikYapan,
                        KayitYapan = i.KayitYapan,
                        AlisTarihi = Convert.ToDateTime(i.AlisTarihi),
                        TeslimTarihi = Convert.ToDateTime(i.TeslimTarihi),
                    });
                }
                return ogrenciList;
            }
        }

        public void Update(KitapOgrenci entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                KitapOgrenci kitapOgrenci = context.KitapOgrenci.Where(n => n.ID == entity.ID).First();
                if (kitapOgrenci != null)
                {
                    kitapOgrenci.OgrenciID = entity.OgrenciID;
                    kitapOgrenci.KitapID = entity.KitapID;
                    kitapOgrenci.AlisTarihi = entity.AlisTarihi;
                    kitapOgrenci.TeslimTarihi = entity.TeslimTarihi;
                    kitapOgrenci.KullaniciID = entity.KullaniciID;
                    kitapOgrenci.DegisiklikYapan = entity.DegisiklikYapan;
                    kitapOgrenci.DegisiklikTarihi = DateTime.Now;
                }
                context.SaveChanges();
            }
        }
    }
}

