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
    
    public partial class Slownik_stanowisko
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Slownik_stanowisko()
        {
            this.Stanowisko_produkcyjne = new HashSet<Stanowisko_produkcyjne>();
        }
    
        public int ID_nazwa_stanowiska { get; set; }
        public string Nazwa_stanowiska { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stanowisko_produkcyjne> Stanowisko_produkcyjne { get; set; }
    }
}