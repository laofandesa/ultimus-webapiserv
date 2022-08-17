using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigSubjectRelation
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string CostTypeName { get; set; }
        public string CostTypeCode { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Remark { get; set; }
    }
}
