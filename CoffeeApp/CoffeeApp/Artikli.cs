//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artikli
    {
        public int ID_Pica { get; set; }
        public string Naziv_Pica { get; set; }
        public string Kolicina { get; set; }
        public double Cijena { get; set; }
    
        public virtual Order_detail Order_details { get; set; }
    }
}
