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
    
    public partial class Wersja_wyposazenia_slownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wersja_wyposazenia_slownik()
        {
            this.Wersja_wyposazenia_pojazd = new HashSet<Wersja_wyposazenia_pojazd>();
            this.Wersja_wyposazenia_produkt = new HashSet<Wersja_wyposazenia_produkt>();
        }
    
        public int ID_wersja_wyposazenia { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wersja_wyposazenia_pojazd> Wersja_wyposazenia_pojazd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wersja_wyposazenia_produkt> Wersja_wyposazenia_produkt { get; set; }
    }
}
