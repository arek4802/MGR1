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
    
    public partial class Kontrola_jakosci_pojazd
    {
        public int ID_kontrola_jakosci_pojazd { get; set; }
        public int ID_montaz_pojazd { get; set; }
        public int ID_pracownik { get; set; }
        public int ID_rodzaj_kontrola { get; set; }
        public System.DateTime Data_kontroli { get; set; }
        public bool Wynik_kontroli { get; set; }
        public string Uwagi { get; set; }
    
        public virtual Montaz_pojazd Montaz_pojazd { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Rodzaj_kontrola Rodzaj_kontrola { get; set; }
    }
}
