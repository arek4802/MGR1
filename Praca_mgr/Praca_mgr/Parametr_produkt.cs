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
    
    public partial class Parametr_produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parametr_produkt()
        {
            this.Kontrola_parametr_produkt = new HashSet<Kontrola_parametr_produkt>();
        }
    
        public int ID_parametr_produkt { get; set; }
        public int ID_produkt { get; set; }
        public int ID_rodzaj_parametr { get; set; }
        public decimal Zakres_dol { get; set; }
        public decimal Zakres_gora { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrola_parametr_produkt> Kontrola_parametr_produkt { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Rodzaj_parametr Rodzaj_parametr { get; set; }
    }
}
