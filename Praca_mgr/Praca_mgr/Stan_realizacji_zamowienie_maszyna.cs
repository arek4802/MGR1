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
    
    public partial class Stan_realizacji_zamowienie_maszyna
    {
        public int ID_zamowienie_maszyna { get; set; }
        public int ID_status_zamowienie { get; set; }
        public System.DateTime Data_stan { get; set; }
        public int ID_pracownik { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Status_zamowienie Status_zamowienie { get; set; }
        public virtual Zamowienie_maszyna Zamowienie_maszyna { get; set; }
    }
}
