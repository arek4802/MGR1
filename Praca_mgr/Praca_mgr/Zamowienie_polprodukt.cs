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
    
    public partial class Zamowienie_polprodukt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienie_polprodukt()
        {
            this.Stan_realizacji_zamowienie_polprodukt = new HashSet<Stan_realizacji_zamowienie_polprodukt>();
            this.Szczegoly_zamowienie_polprodukt = new HashSet<Szczegoly_zamowienie_polprodukt>();
        }
    
        public int ID_zamowienie_polprodukt { get; set; }
        public int ID_pracownik { get; set; }
        public System.DateTime Data_zamowienia { get; set; }
        public int ID_dostawca { get; set; }
    
        public virtual Dostawca Dostawca { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stan_realizacji_zamowienie_polprodukt> Stan_realizacji_zamowienie_polprodukt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_zamowienie_polprodukt> Szczegoly_zamowienie_polprodukt { get; set; }
    }
}