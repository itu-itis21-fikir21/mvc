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
    
    public partial class recommended
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public recommended()
        {
            this.watch_list = new HashSet<watch_list>();
        }
    
        public string user_name { get; set; }
        public Nullable<int> recommended_movie_id { get; set; }
        public string genre { get; set; }
        public int user_id { get; set; }
    
        public virtual user_profile user_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<watch_list> watch_list { get; set; }
    }
}