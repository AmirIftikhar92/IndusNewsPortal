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
    
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string DocName { get; set; }
        public string DocDetails { get; set; }
        public string DocContentType { get; set; }
        public byte[] DocFile { get; set; }
        public string DocEmployeeId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
