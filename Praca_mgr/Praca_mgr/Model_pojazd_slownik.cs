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
    
    public partial class Model_pojazd_slownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model_pojazd_slownik()
        {
            this.Marka_model = new HashSet<Marka_model>();
        }
    
        public int ID_model_pojazd { get; set; }
        public string Nazwa { get; set; }
        public int Rok_produkcji_od { get; set; }
        public int Rok_produkcji_do { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marka_model> Marka_model { get; set; }
    }
}