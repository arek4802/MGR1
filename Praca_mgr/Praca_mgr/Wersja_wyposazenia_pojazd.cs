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
    
    public partial class Wersja_wyposazenia_pojazd
    {
        public int ID_wersja_wyposazenia_pojazd { get; set; }
        public int ID_wersja_wyposazenia { get; set; }
        public int ID_pojazd { get; set; }
    
        public virtual Pojazd Pojazd { get; set; }
        public virtual Wersja_wyposazenia_slownik Wersja_wyposazenia_slownik { get; set; }
    }
}