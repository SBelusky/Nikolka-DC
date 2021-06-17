//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skuska.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class zakaznik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zakaznik()
        {
            this.cvicenie = new HashSet<cvicenie>();
            this.faktura = new HashSet<faktura>();
            this.permanentka = new HashSet<permanentka>();
        }
    
        public int id { get; set; }
        public string meno_dietata { get; set; }
        public string priezvisko_dietata { get; set; }
        public string ulica { get; set; }
        public string mesto { get; set; }
        public Nullable<int> sucastna_permanentka { get; set; }
        public string meno_rodica { get; set; }
        public string priezvisko_rodica { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string zdravotny_stav { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cvicenie> cvicenie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<faktura> faktura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permanentka> permanentka { get; set; }
    }
}