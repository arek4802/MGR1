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
    
    public partial class Szczegol_reklamacja_pojazd
    {
        public int ID_szczegol_reklamacja_pojazd { get; set; }
        public int ID_reklamacja_pojazd { get; set; }
        public int ID_typ_reklamacja { get; set; }
        public int ID_pojazd { get; set; }
    
        public virtual Pojazd Pojazd { get; set; }
        public virtual Reklamacja_pojazd Reklamacja_pojazd { get; set; }
        public virtual Typ_reklamacja Typ_reklamacja { get; set; }
    }
}
