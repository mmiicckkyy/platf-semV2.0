//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P.V.WantHelp_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cursos
    {
        public Cursos()
        {
            this.inscripcion = new HashSet<inscripcion>();
            this.Material = new HashSet<Material>();
            this.sesiones = new HashSet<sesiones>();
        }
    
        public int Id_Curso { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha_I { get; set; }
        public System.DateTime Fecha_F { get; set; }
        public string urlBase { get; set; }
        public string urlHost { get; set; }
    
        public virtual ICollection<inscripcion> inscripcion { get; set; }
        public virtual ICollection<Material> Material { get; set; }
        public virtual ICollection<sesiones> sesiones { get; set; }
    }
}
