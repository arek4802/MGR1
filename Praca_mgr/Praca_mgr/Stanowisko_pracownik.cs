//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praca_mgr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stanowisko_pracownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stanowisko_pracownik()
        {
            this.Umowa = new HashSet<Umowa>();
        }
    
        public int ID_stanowisko_pracownik { get; set; }
        public int ID_stanowisko { get; set; }
        public int ID_pracownik { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Stanowisko Stanowisko { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Umowa> Umowa { get; set; }
    }
}
