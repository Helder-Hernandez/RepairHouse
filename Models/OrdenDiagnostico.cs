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
    using System.ComponentModel.DataAnnotations;

    public partial class OrdenDiagnostico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenDiagnostico()
        {
            this.Diagnostico = new HashSet<Diagnostico>();
            this.OrdenDiagnosticoDetalle = new HashSet<OrdenDiagnosticoDetalle>();
        }

        [Display(Name = "Id")]
        public int IdOrdenDiagnostico { get; set; }

        [Display(Name = "Emitido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaEmision { get; set; }

        [Display(Name = "Resuelto")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaResolucion { get; set; }
        public int IdSucursal { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public string Comentarios { get; set; }

        [Display(Name = "N. equipos")]
        public Nullable<int> CantidadEquipos { get; set; }

        [Display(Name = "Precio bruto")]
        public Nullable<decimal> PrecioBruto { get; set; }

        public Nullable<decimal> Descuento { get; set; }


        [Display(Name = "Precio neto")]
        public Nullable<decimal> PrecioNeto { get; set; }
        public int IdEstado { get; set; }
        public Nullable<bool> Facturado { get; set; }

        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostico> Diagnostico { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual EstadoOrdenDiagnostico EstadoOrdenDiagnostico { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDiagnosticoDetalle> OrdenDiagnosticoDetalle { get; set; }
    }
}
