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

    public partial class OrdenCompra
    {
        public int IdOrdenCompra { get; set; }
        public Nullable<int> Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<int> IdProveedor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<decimal> PrecioBruto { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> FacturaProveedor { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
    }
}
