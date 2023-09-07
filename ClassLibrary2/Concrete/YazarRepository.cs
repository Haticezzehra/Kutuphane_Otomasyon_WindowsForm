using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class YazarRepository
    {
        public void Add(Yazar yazar)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())
            {
                context.Yazar.Add(yazar);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())
            {
                Yazar yazar = context.Yazar.Where(n => n.ID == Id).First();
                context.Yazar.Remove(yazar);
                context.SaveChanges();
            }
        }


        public Yazar GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var yazar = context.Yazar.Where(n => n.ID == Id).First();
                return yazar;
            }

        }

        public List<GetModelYazar> GetAll()
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                List<GetModelYazar> yazarList = new List<GetModelYazar>();
                foreach (var i in context.Yazar.ToList())
                {
                    yazarList.Add(new GetModelYazar()
                    {
                        ID = i.ID,
                        AdSoyad = i.AdSoyad,
                        DegisiklikYapan = i.DegisiklikYapan,
                        DegisiklikTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        KayitYapan = i.KayıtYapan,
                        KayitTarihi = Convert.ToDateTime(i.KayıtTarihi)

                    });
                }
                return yazarList;

            }

        }

        public void Update(Yazar entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Yazar yazar = context.Yazar.Where(n => n.ID == entity.ID).First();
                if (yazar != null)
                {
                    yazar.AdSoyad = entity.AdSoyad;
                    yazar.DegisiklikYapan = entity.DegisiklikYapan;
                    yazar.DegisiklikTarihi = DateTime.Now;
                }

                context.SaveChanges();
            }

        }
    }
}
