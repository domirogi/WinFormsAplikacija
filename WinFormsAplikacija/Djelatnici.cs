//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsAplikacija
{
    using System;
    using System.Collections.Generic;
    
    public partial class Djelatnici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Djelatnici()
        {
            this.ClanoviObitelji = new HashSet<ClanoviObitelji>();
        }
    
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<System.DateTime> DatumRodjena { get; set; }
        public string OIB { get; set; }
        public string Spol { get; set; }
        public string Drzavljanstvo { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClanoviObitelji> ClanoviObitelji { get; set; }
    }
}
