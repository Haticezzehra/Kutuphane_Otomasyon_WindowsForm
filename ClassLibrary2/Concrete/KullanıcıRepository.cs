using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Threading.Tasks;
using DataAccessLayer.Crypto;

namespace DataAccessLayer.Concrete
{
    public class KullanıcıRepository
    {
        
        public void Add(Kullanici kullanıcı)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {


                kullanıcı.Parola = Sifrele.SifreleAES(kullanıcı.Parola, "Sifrele");
                context.Kullanici.Add(kullanıcı);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Kullanici kullanıcı = context.Kullanici.Where(n => n.ID == Id).First();

                context.Kullanici.Remove(kullanıcı);
                context.SaveChanges();
            }
        }


        public Kullanici GetEntity(int Id)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                var kullanıcı = context.Kullanici.Where(n => n.ID == Id).First();
                kullanıcı.Parola = Sifrele.SifreyiCozAES(kullanıcı.Parola, "Sifrele");
                return kullanıcı;
            }

        }

        public List<GetModelKullanici> GetAll()
        {

            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                List<GetModelKullanici> kullanıcıList = new List<GetModelKullanici>();
                foreach (var i in context.Kullanici.ToList())
                {
                    kullanıcıList.Add(new GetModelKullanici()
                    {
                        ID = i.ID,
                        Parola = i.Parola,
                        KullaniciAdi = i.KullaniciAdi,
                        DegisiklikTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        DegisiklikYapan = i.DegisiklikYapan,
                        KayitTarihi = Convert.ToDateTime(i.DegisiklikTarihi),
                        KayitYapan = i.KayıtYapan

                    });
                }
                return kullanıcıList;

            }

        }

        public void Update(Kullanici entity)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Kullanici kullanici = context.Kullanici.Where(n => n.ID == entity.ID).First();
                if (kullanici != null)
                {
                    kullanici.KullaniciAdi = entity.KullaniciAdi;
                    kullanici.Parola = entity.Parola;
                    kullanici.DegisiklikYapan = entity.DegisiklikYapan;
                    kullanici.DegisiklikTarihi = DateTime.Now;
                }
                context.SaveChanges();
            }
        }
        
    }
}



