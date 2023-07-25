//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uygulama1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class film_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public film_list()
        {
            this.user_comment = new HashSet<user_comment>();
        }
    
        public int film_id { get; set; }
        public string director_name { get; set; }
        public string director_lastName { get; set; }
        public string film_name { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<decimal> imdb { get; set; }
    
        public virtual genre genre { get; set; }
        public virtual film_scores film_scores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_comment> user_comment { get; set; }
        public virtual watch_list watch_list { get; set; }
    }
}
