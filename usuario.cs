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
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.delivery = new HashSet<delivery>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int tipo_usuario { get; set; }
        public Nullable<bool> ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<delivery> delivery { get; set; }
        public virtual tipo_usuario tipo_usuario1 { get; set; }
    }
}
