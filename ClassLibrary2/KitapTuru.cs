//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class KitapTuru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KitapTuru()
        {
            this.Kitap = new HashSet<Kitap>();
        }
    
        public int ID { get; set; }
        public string Adi { get; set; }
        public string KayitYapan { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public string DegisiklikYapan { get; set; }
        public Nullable<System.DateTime> DegisiklikTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitap> Kitap { get; set; }
    }
}
