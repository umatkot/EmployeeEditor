//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeEditor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employeers
    {
        public int ID { get; set; }
        public Nullable<int> Department { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateBirth { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
        public virtual Departments Departments { get; set; }
    }
}
