//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(IncidenciasMetadata))]
    public partial class Incidencias
    {
        public int Id { get; set; }
        public Nullable<int> FK_Usuario { get; set; }
        public int FK_Estado { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual EstadoIncidencia EstadoIncidencia { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
