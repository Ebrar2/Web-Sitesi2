//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazLab
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_siteler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_siteler()
        {
            this.tbl_urunAciklama = new HashSet<tbl_urunAciklama>();
        }
    
        public int SiteId { get; set; }
        public string SiteAd { get; set; }
        public string SiteLogo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_urunAciklama> tbl_urunAciklama { get; set; }
    }
}
