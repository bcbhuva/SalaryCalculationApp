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
    
    public partial class SalaryCalculation
    {
        public string SalaryCalculationId { get; set; }
        public System.DateTime PeriodStartDate { get; set; }
        public System.DateTime PeriodEndDate { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Tax { get; set; }
        public string EmployeeId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
