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
    
    public partial class v_Proces_wytwarzanie_polprodukt_ewidencja
    {
        public int ID { get; set; }
        public string Półprodukt { get; set; }
        public string Czynność_produkcyjna { get; set; }
        public int ID_pracownik { get; set; }
        public string Pracownik { get; set; }
        public string Stanowisko { get; set; }
        public int Szacowany_czas__min_ { get; set; }
        public System.DateTime Data_rozpoczęcia { get; set; }
        public Nullable<System.DateTime> Data_zakończenia { get; set; }
        public int Czas_pracy { get; set; }
    }
}
