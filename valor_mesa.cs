//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzariaJulubom
{
    using System;
    using System.Collections.Generic;
    
    public partial class valor_mesa
    {
        public int id { get; set; }
        public int id_mesa { get; set; }
        public decimal valor { get; set; }
    
        public virtual mesa mesa { get; set; }
    }
}