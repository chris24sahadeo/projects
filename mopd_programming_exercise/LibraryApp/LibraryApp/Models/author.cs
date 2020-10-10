//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public author()
        {
            this.bookauthors = new HashSet<bookauthor>();
        }

        [ScaffoldColumn(false)]
        public System.Guid author_id { get; set; }

        [Display(Name="First Name")]
        public string first_name { get; set; }

        [Display(Name ="Last Name")]
        public string last_name { get; set; }

        [ScaffoldColumn(false)]
        public string full_name { get { return string.Format("{0} {1}", first_name, last_name); } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bookauthor> bookauthors { get; set; }
    }
}