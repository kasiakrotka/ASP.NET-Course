//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KatarzynaKrawczykLab8Zad1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KatarzynaKrawczykEntries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KatarzynaKrawczykEntries()
        {
            this.KatarzynaKrawczykImages = new HashSet<KatarzynaKrawczykImages>();
        }
    
        public int Id { get; set; }
        public string Keyword { get; set; }
        public string Definition { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KatarzynaKrawczykImages> KatarzynaKrawczykImages { get; set; }
    }
}