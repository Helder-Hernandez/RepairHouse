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
    
    public partial class OrdenDiagnosticoDetalle
    {
        public int IdOrdenDiagnosticoDetalle { get; set; }
        public int IdEquipo { get; set; }
        public int IdOrdenDiagnostico { get; set; }
        public int IdInventario { get; set; }
        public Nullable<decimal> Costo { get; set; }
    
        public virtual Equipo Equipo { get; set; }
        public virtual Inventario Inventario { get; set; }
        public virtual OrdenDiagnostico OrdenDiagnostico { get; set; }
    }
}
