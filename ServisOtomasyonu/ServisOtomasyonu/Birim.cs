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
    
    public partial class Birim
    {
        public int Id { get; set; }
        public int MagazaId { get; set; }
        public string BirimAdi { get; set; }
    
        public virtual Magaza Magaza { get; set; }
    }
}
