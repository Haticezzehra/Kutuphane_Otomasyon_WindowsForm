using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GetModelOgrenci : BaseEntity
    {
       public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Sinif { get; set; }
        public string Bolum { get; set; }
        public string OkulNo { get; set; }
    }
}
