using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryQualificationInfo
    {
        public int Id { get; set; }
        public string QualificationId { get; set; }
        public string QualificationName { get; set; }
        public int StepInfoFk { get; set; }
        public string QualificationDeptName { get; set; }
    }
}
