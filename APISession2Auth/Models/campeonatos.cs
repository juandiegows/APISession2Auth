//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APISession2Auth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class campeonatos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public campeonatos()
        {
            this.jogos = new HashSet<jogos>();
            this.participacoes = new HashSet<participacoes>();
        }
    
        public int cod_camp { get; set; }
        public string dsc_camp { get; set; }
        public int ano { get; set; }
        public string tipo { get; set; }
        public System.DateTime dat_ini { get; set; }
        public System.DateTime dat_fim { get; set; }
        public string def_tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jogos> jogos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participacoes> participacoes { get; set; }
    }
}
