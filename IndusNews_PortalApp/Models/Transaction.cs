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
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string TransStatus { get; set; }
        public string TransAmount { get; set; }
        public string TransDetails { get; set; }
        public string EmpId { get; set; }
        public string BankAccount { get; set; }
        public string TransactionBy { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
