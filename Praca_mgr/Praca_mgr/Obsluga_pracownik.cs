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
    
    public partial class Obsluga_pracownik
    {
        public int ID_obsluga_pracownik { get; set; }
        public int ID_obsluga { get; set; }
        public int ID_pracownik { get; set; }
    
        public virtual Obsluga Obsluga { get; set; }
        public virtual Pracownik Pracownik { get; set; }
    }
}
