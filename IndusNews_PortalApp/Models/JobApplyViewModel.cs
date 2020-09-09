using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndusNews_PortalApp.Models
{
    public class JobApplyViewModel
    {
        [Key]
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPhone { get; set; }
        public Nullable<int> AppliedJob { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public int CVId { get; set; }
        public string CVFileName { get; set; }
        public string CVContentType { get; set; }
        public byte[] CVFile { get; set; }
        public virtual JobApplicant JobApplicant { get; set; }
        public virtual ICollection<JobApplicant> JobApplicants { get; set; }
        public virtual ICollection<CV> CVs { get; set; }
        public virtual Job Job { get; set; }
    }
}