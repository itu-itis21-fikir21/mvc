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
    
    public partial class genre
    {
        public string film_name { get; set; }
        public string genre1 { get; set; }
        public int film_id { get; set; }
    
        public virtual film_list film_list { get; set; }
    }
}
