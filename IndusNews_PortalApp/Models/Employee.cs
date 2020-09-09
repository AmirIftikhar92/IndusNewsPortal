//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndusNews_PortalApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Attendances = new HashSet<Attendance>();
            this.Documents = new HashSet<Document>();
            this.LeaveApplications = new HashSet<LeaveApplication>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpDept { get; set; }
        public string EmpCNIC { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        public string Emp2ndPhone { get; set; }
        public string EmpAddress { get; set; }
        public string JobCity { get; set; }
        public string SalaryPackage { get; set; }
        public string JobStatus { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
        public string EmpUsername { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
