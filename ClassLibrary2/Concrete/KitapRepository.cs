using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DataAccessLayer.Concrete
{
    public class KitapRepository
    {
        public void Add(Kitap entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                entity.KayitTarihi = DateTime.Now;
                context.Kitap.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Kitap kitap = context.Kitap.Where(n => n.ID == Id).First();
                context.Kitap.Remove(kitap);
                context.SaveChanges();
            }
        }

        public List<GetModelKitap> GetAll()
        {
            using (KutuphaneEntities context = new KutuphaneEntities())
            {
                List<GetModelKitap> getModelKitap = new List<GetModelKitap>();
                foreach (var i in context.Kitap.ToList())
                {
                    getModelKitap.Add(new GetModelKitap()
                    {
                        ID = i.ID,
                        Adi = i.Adi,
                        SayfaSayisi = Convert.ToUInt16(i.SayfaSayisi),
                        KitapTurID = i.KitapTurID,
                        KitapTurAdı = context.KitapTuru.Where(n => n.ID == i.KitapTurID).First().Adi,
                        YayinEviID = i.YayınEviID,
                        YayinEviAdı = context.YayinEvi.Where(n => n.ID == i.YayınEviID).First().Adi,
                        YazarID = i.YazarID,
                        YazarAdi = context.Yazar.Where(n => n.ID == i.YazarID).First().AdSoyad,
                        Barkod = i.Barkod,
                        KayitYapan = i.KayitYapan,
                        KayitTarihi = Convert.ToDateTime(i.KayitTarihi),
                        DegisiklikTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        DegisiklikYapan = i.DegisiklikYapan,
                        Resim = i.Resim,
                    });
                }
                return getModelKitap;
            }
        }

        public GetModelKitap GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {

                var kitap = context.Kitap.Where(n => n.ID == Id).First();
                GetModelKitap ktp = new GetModelKitap
                {
                    Adi = kitap.Adi,
                    Barkod = kitap.Barkod,
                    KitapTurAdı = context.KitapTuru.Where(n => n.ID == kitap.KitapTurID).First().Adi,
                    YayinEviAdı = context.YayinEvi.Where(n => n.ID == kitap.YayınEviID).First().Adi,
                    YazarAdi = context.Yazar.Where(n => n.ID == kitap.YazarID).First().AdSoyad,
                    DegisiklikYapan = kitap.DegisiklikYapan,
                    KayitYapan = kitap.KayitYapan,
                    KayitTarihi = Convert.ToDateTime(kitap.KayitTarihi),
                    DegisiklikTarihi = Convert.ToDateTime(kitap.DegisiklikTarihi),
                    ID=kitap.ID,
                    KitapTurID=kitap.KitapTurID,
                    SayfaSayisi=kitap.SayfaSayisi,
                    Resim=kitap.Resim,
                    YayinEviID=kitap.YayınEviID,
                    YazarID=kitap.YazarID,


                };
                return ktp;
            }
        }

        public void Update(Kitap entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Kitap kitap = context.Kitap.Where(n => n.ID == entity.ID).First();
                if (kitap != null)
                {
                    kitap.Adi = entity.Adi;
                    kitap.SayfaSayisi = entity.SayfaSayisi;
                    kitap.KitapTurID = entity.KitapTurID;
                    kitap.YayınEviID = entity.YayınEviID;
                    kitap.YazarID = entity.YazarID;
                    kitap.Barkod = entity.Barkod;
                    kitap.DegisiklikYapan = entity.DegisiklikYapan;
                    kitap.DegisiklikTarihi = DateTime.Now;
                    kitap.Resim = entity.Resim;
                }
                context.SaveChanges();

            }
        }
    }
}
