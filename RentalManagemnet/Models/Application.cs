//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalManagemnet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int applicationID { get; set; }
        public Nullable<int> tenantID { get; set; }
        public string applicationDescription { get; set; }
        public string applicationStatus { get; set; }
        public string applicationTitle { get; set; }
    
        public virtual Tenant Tenant { get; set; }
    }
}
