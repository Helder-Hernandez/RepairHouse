//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
