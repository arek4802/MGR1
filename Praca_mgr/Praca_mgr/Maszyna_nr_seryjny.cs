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
    
    public partial class Maszyna_nr_seryjny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maszyna_nr_seryjny()
        {
            this.Sklad_stanowisko_produkcyjne_maszyna = new HashSet<Sklad_stanowisko_produkcyjne_maszyna>();
        }
    
        public int ID_maszyna_nr { get; set; }
        public int ID_maszyna { get; set; }
        public int ID_nr_seryjny { get; set; }
    
        public virtual Maszyna Maszyna { get; set; }
        public virtual Nr_seryjny Nr_seryjny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_stanowisko_produkcyjne_maszyna> Sklad_stanowisko_produkcyjne_maszyna { get; set; }
    }
}
