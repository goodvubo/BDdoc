//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDdoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Education
    {
        public int edu_ID { get; set; }
        public string edu_Name { get; set; }
        public Nullable<int> ID { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
