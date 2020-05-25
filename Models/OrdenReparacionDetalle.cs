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
    
    public partial class OrdenReparacionDetalle
    {
        public int IdOrdenReparacionDetalle { get; set; }
        public int IdOrdenReparacion { get; set; }
        public int IdEquipo { get; set; }
        public int IdEmpleado { get; set; }
        public int IdInventario { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Equipo Equipo { get; set; }
        public virtual Inventario Inventario { get; set; }
        public virtual OrdenReparacion OrdenReparacion { get; set; }
    }
}
