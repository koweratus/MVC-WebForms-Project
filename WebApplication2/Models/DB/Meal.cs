//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meal()
        {
            this.Namirnices = new HashSet<Namirnice>();
            this.Namirnices1 = new HashSet<Namirnice>();
        }
    
        public int ID_Meals { get; set; }
        public string Mealss { get; set; }
        public Nullable<double> Masti { get; set; }
        public Nullable<double> Bjelancevine { get; set; }
        public Nullable<double> Ugljikohidrati { get; set; }
        public Nullable<double> Suma { get; set; }
        public string VridiDo { get; set; }
        public string VridiOd { get; set; }
        public Nullable<double> n { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Namirnice> Namirnices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Namirnice> Namirnices1 { get; set; }
    }
}
