using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class YayinEviRepository
    {
        public void Add(YayinEvi yayinEvi)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())
            {
                context.YayinEvi.Add(yayinEvi);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                YayinEvi yayinEvi = context.YayinEvi.Where(n => n.ID == Id).First();
                context.YayinEvi.Remove(yayinEvi);
                context.SaveChanges();
            }
        }
        public GetModelYayinEvi GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var yayinevi = context.YayinEvi.Where(n => n.ID == Id).First();
                GetModelYayinEvi yayinEvi = new GetModelYayinEvi()
                {
                    Adı = yayinevi.Adi,
                    ID = yayinevi.ID,
                    DegisiklikTarihi = Convert.ToDateTime(yayinevi.DegisiklikTarihi),
                    DegisiklikYapan=yayinevi.DegisiklikYapan,
                    KayitTarihi=Convert.ToDateTime(yayinevi.KayitTarihi),
                    KayitYapan=yayinevi.KayitYapan,


                };
                return yayinEvi;
            }
        }

        public List<YayinEvi> GetAll()
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                List<YayinEvi> yayinEviList = new List<YayinEvi>();
                foreach (var i in context.YayinEvi.ToList())
                {
                    yayinEviList.Add(new YayinEvi()
                    {
                        ID = i.ID,
                        Adi = i.Adi,
                        DegisiklikTarihi = i.DegisiklikTarihi,
                        DegisiklikYapan = i.DegisiklikYapan,
                        KayitTarihi = i.KayitTarihi,
                        KayitYapan = i.KayitYapan,
                    });
                }
                return yayinEviList;

            }

        }

        public void Update(YayinEvi entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                YayinEvi yayinEvi = context.YayinEvi.Where(n => n.ID == entity.ID).First();
                if (yayinEvi != null)
                {
                    yayinEvi.Adi = entity.Adi;
                    yayinEvi.DegisiklikTarihi = DateTime.Now;
                    yayinEvi.DegisiklikYapan = entity.DegisiklikYapan;
                }
                context.SaveChanges();
            }
        }
    }
}
