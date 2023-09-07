using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer.Concrete
{
    public class KitapTuruRepository
    {
        public List<GetModelKitapTuru> GetAll()
        {

            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                List<GetModelKitapTuru> kitapTuruList = new List<GetModelKitapTuru>();
                foreach (var i in context.KitapTuru.ToList())
                {
                    kitapTuruList.Add(new GetModelKitapTuru()
                    {
                        ID = i.ID,
                        Adi = i.Adi,
                        KayitYapan = i.KayitYapan,
                        KayitTarihi = Convert.ToDateTime(i.KayitTarihi),
                        DegisiklikTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        DegisiklikYapan = i.DegisiklikYapan
                    });
                }
                return kitapTuruList;
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                KitapTuru kitapturu = context.KitapTuru.Where(n => n.ID == Id).First();

                context.KitapTuru.Remove(kitapturu);
                context.SaveChanges();
            }
        }


        public KitapTuru GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var kitapTuru = context.KitapTuru.Where(n => n.ID == Id).First();
                return kitapTuru;
            }

        }
        public void Add(KitapTuru kitapTuru)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                context.KitapTuru.Add(kitapTuru);
                context.SaveChanges();
            }
        }
        public void Update(KitapTuru entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                KitapTuru kitapTuru = context.KitapTuru.Where(n => n.ID == entity.ID).First();
                if (kitapTuru != null)
                {
                    kitapTuru.Adi = entity.Adi;
                    kitapTuru.DegisiklikYapan = entity.DegisiklikYapan;
                    kitapTuru.DegisiklikTarihi = DateTime.Now;
                }
                context.SaveChanges();
            }


        }
    }
}
