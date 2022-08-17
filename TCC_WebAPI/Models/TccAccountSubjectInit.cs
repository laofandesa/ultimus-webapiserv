using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAccountSubjectInit
    {
        public int Id { get; set; }
        public int? OwnerType { get; set; }
        public string DeptOrProject { get; set; }
        public string Category { get; set; }
        public int? DomesticOversea { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int SubjectLevel { get; set; }
        public string ParentSubjectCode { get; set; }
        public int? Sort { get; set; }
        public string Unitid { get; set; }
        public string Orgname { get; set; }
        public string Subjectmc { get; set; }
        public string Asstype { get; set; }
        public int? Acctyear { get; set; }
    }
}
