using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;

namespace DataAccessLayer.Concrete
{
    public class OgrenciRepository // : EntityRepositoryBase<GetModelOgrenci>, IEntityRepository<GetModelOgrenci>
    {
        public void Add(Ogrenci ogrenci)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                context.Ogrenci.Add(ogrenci);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Ogrenci ogr = context.Ogrenci.Where(n => n.ID == Id).First();
                context.Ogrenci.Remove(ogr);
                context.SaveChanges();
            }
        }


        public Ogrenci GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var ogrenci = context.Ogrenci.Where(n => n.ID == Id).First();
                return ogrenci;
            }

        }

        public List<GetModelOgrenci> GetAll()
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                List<GetModelOgrenci> ogrenciList = new List<GetModelOgrenci>();
                foreach (var i in context.Ogrenci.ToList())
                {
                    ogrenciList.Add(new GetModelOgrenci()
                    {
                        ID = i.ID,
                        AdSoyad = i.AdSoyad,
                        Bolum = i.Bolum,
                        DegisiklikTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        KayitTarihi = Convert.ToDateTime(i.KayıtTarihi),
                        DegisiklikYapan = i.DegisiklikYapan,
                        KayitYapan = i.KayıtYapan,
                        OkulNo = i.OkulNo,
                        Sinif = i.Sınıf
                    });
                }
                return ogrenciList;

            }

        }

        public void Update(Ogrenci entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Ogrenci ogr = context.Ogrenci.Where(n => n.ID == entity.ID).First();
                if (ogr != null)
                {
                    ogr.AdSoyad = entity.AdSoyad;
                    ogr.Bolum = entity.Bolum;
                    ogr.OkulNo = entity.OkulNo;
                    ogr.Sınıf = entity.Sınıf;
                    ogr.DegisiklikYapan = entity.DegisiklikYapan;
                    ogr.DegisiklikYapan = entity.DegisiklikYapan;
                    ogr.DegisiklikTarihi = DateTime.Now;
                }

                context.SaveChanges();
            }

        }


    }

}

