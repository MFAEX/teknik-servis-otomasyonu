//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServisOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            this.Cihaz = new HashSet<Cihaz>();
            this.Fatura = new HashSet<Fatura>();
        }
    
        public int Id { get; set; }
        public string Cari_No { get; set; }
        public string Unvan { get; set; }
        public string Yetkili { get; set; }
        public string GSM { get; set; }
        public string Sabit { get; set; }
        public string E_Mail { get; set; }
        public string Vergi_Dairesi { get; set; }
        public string Vergi_No { get; set; }
        public string Sevk_Adresi { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Posta_Kodu { get; set; }
        public string Fatura_Adresi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cihaz> Cihaz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }
    }
}
