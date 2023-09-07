using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class GetModelKullanici:BaseEntity
    {
        public int ID { get; set; }
       public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
    }
}
