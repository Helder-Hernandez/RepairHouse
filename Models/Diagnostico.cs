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
    using System.ComponentModel.DataAnnotations;

    public partial class Diagnostico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnostico()
        {
            this.DiagnosticoCotizacion = new HashSet<DiagnosticoCotizacion>();
        }
    
        public int IdDiagnostico { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public int IdEquipo { get; set; }
        public int IdTecnico { get; set; }
        public int IdOrdenDiagnostico { get; set; }
        public string Diagnostico1 { get; set; }
        public string ComentariosCotizacion { get; set; }
        public Nullable<decimal> TotalCotizacion { get; set; }
    
        public virtual Equipo Equipo { get; set; }
        public virtual OrdenDiagnostico OrdenDiagnostico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiagnosticoCotizacion> DiagnosticoCotizacion { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
