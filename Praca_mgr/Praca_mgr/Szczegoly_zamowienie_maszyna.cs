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
    
    public partial class Szczegoly_zamowienie_maszyna
    {
        public int ID_zamowienie_maszyna { get; set; }
        public int ID_maszyna { get; set; }
        public int ID_producent { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }
    
        public virtual Maszyna Maszyna { get; set; }
        public virtual Producent Producent { get; set; }
        public virtual Zamowienie_maszyna Zamowienie_maszyna { get; set; }
    }
}
