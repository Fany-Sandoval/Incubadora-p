
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Incubadora.Repository
{

using System;
    using System.Collections.Generic;
    
public partial class Status
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Status()
    {

        this.CatCarreras = new HashSet<CatCarreras>();

        this.DatosLaborales = new HashSet<DatosLaborales>();

        this.SubModuloSesionesProyecto = new HashSet<SubModuloSesionesProyecto>();

        this.Proyectos = new HashSet<Proyectos>();

        this.Emprendedores = new HashSet<Emprendedores>();

    }


    public int Id { get; set; }

    public string StrValor { get; set; }

    public string StrDescripcion { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CatCarreras> CatCarreras { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DatosLaborales> DatosLaborales { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SubModuloSesionesProyecto> SubModuloSesionesProyecto { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Proyectos> Proyectos { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Emprendedores> Emprendedores { get; set; }

}

}
