//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Filter
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pattern { get; set; }
        public string Replacement { get; set; }
        public Nullable<int> AppliesTo { get; set; }
        public Nullable<int> Action { get; set; }
        public System.DateTime CreationDate { get; set; }
    }
}