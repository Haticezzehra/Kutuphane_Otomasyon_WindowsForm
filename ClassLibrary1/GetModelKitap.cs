using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class GetModelKitap:BaseEntity
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public int? SayfaSayisi { get; set; }
        public string KitapTurAdı { get; set; }
       public int? KitapTurID { get; set; }
        public string YayinEviAdı { get; set; }
        public int? YayinEviID { get; set; }
        public string YazarAdi { get; set; }
        public int? YazarID { get; set; }
        public string Barkod { get; set; }
        public byte[] Resim { get; set; }
        
        
        


    }
}
