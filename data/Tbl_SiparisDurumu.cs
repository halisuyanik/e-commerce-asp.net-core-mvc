//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace on_e_commerce.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_SiparisDurumu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_SiparisDurumu()
        {
            this.Tbl_SiparisDetay = new HashSet<Tbl_SiparisDetay>();
        }
    
        public int Id { get; set; }
        public string SiparisDurumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SiparisDetay> Tbl_SiparisDetay { get; set; }
    }
}
