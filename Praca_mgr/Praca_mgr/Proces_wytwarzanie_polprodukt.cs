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
    
    public partial class Proces_wytwarzanie_polprodukt
    {
        public int ID_proces_wytwarzanie_polprodukt { get; set; }
        public int ID_wytwarzanie { get; set; }
        public Nullable<int> ID_proces_polprodukt { get; set; }
    
        public virtual Proces_polprodukt_czynnosc Proces_polprodukt_czynnosc { get; set; }
        public virtual Wytwarzanie Wytwarzanie { get; set; }
    }
}
