//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepairHouse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModeloEquipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModeloEquipo()
        {
            this.Equipo = new HashSet<Equipo>();
        }
    
        public int IdModelo { get; set; }
        public string Modelo { get; set; }
        public int IdMarca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipo> Equipo { get; set; }
        public virtual MarcaEquipo MarcaEquipo { get; set; }
    }
}
