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
    
    public partial class Marka_model_pojazd
    {
        public int ID_marka_model_pojazd { get; set; }
        public int ID_typ_pojazd_model { get; set; }
        public int ID_pojazd { get; set; }
    
        public virtual Pojazd Pojazd { get; set; }
        public virtual Typ_pojazd_model Typ_pojazd_model { get; set; }
    }
}