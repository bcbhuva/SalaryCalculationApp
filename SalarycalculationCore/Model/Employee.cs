//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mikkark.SCA.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Taxcards = new HashSet<Taxcard>();
        }
    
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string EmployerId { get; set; }
    
        public virtual Employer Employer { get; set; }
        public virtual ICollection<Taxcard> Taxcards { get; set; }
    }
}
