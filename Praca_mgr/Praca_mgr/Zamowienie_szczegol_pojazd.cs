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
    
    public partial class Zamowienie_szczegol_pojazd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienie_szczegol_pojazd()
        {
            this.Montaz_pojazd = new HashSet<Montaz_pojazd>();
            this.Zamowienie_produkt = new HashSet<Zamowienie_produkt>();
        }
    
        public int ID_zamowienie_szczegol_pojazd { get; set; }
        public int ID_zamowienie { get; set; }
        public int ID_pojazd { get; set; }
        public int ID_gwarancja { get; set; }
        public int Koszt { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Gwarancja Gwarancja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Montaz_pojazd> Montaz_pojazd { get; set; }
        public virtual Pojazd Pojazd { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie_produkt> Zamowienie_produkt { get; set; }
    }
}