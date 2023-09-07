using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class GetModelKitapOgrenci : BaseEntity
    {
        public int ID { get; set; }
        public string OgrenciAdı { get; set; }
        public int? OgrenciID { get; set; }
        
        public int? KitapID { get; set; }
        public string kitapAdi { get; set; }
        public int? KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }

    }
}
