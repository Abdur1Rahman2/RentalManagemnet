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
    
    public partial class Notice
    {
        public int noticeID { get; set; }
        public string noticeDescription { get; set; }
        public Nullable<System.DateTime> noticeDate { get; set; }
        public Nullable<int> propertyID { get; set; }
        public string noticeTitle { get; set; }
    
        public virtual Property Property { get; set; }
    }
}
