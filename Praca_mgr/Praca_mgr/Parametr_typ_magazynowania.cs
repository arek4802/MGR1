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
    
    public partial class Parametr_typ_magazynowania
    {
        public int ID_parametr_typ_magazynowania { get; set; }
        public int ID_magazynowanie { get; set; }
        public int ID_rodzaj_parametr { get; set; }
        public int Wartosc_dolna { get; set; }
        public int Wartosc_gorna { get; set; }
    
        public virtual Magazynowanie_slownik Magazynowanie_slownik { get; set; }
        public virtual Rodzaj_parametr Rodzaj_parametr { get; set; }
    }
}
