//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Results
    {
        public int id { get; set; }
        public int IDEmployee { get; set; }
        public int IDUser { get; set; }
        public string FileName { get; set; }
        public byte[] Text { get; set; }
        public string Title { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual Users Users { get; set; }
    }
}