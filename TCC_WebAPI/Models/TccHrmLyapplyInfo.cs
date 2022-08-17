using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmLyapplyInfo
    {
        public int Id { get; set; }
        public int? TccHrmLyapplyDetailNewPersonFk { get; set; }
        public string FormNumber { get; set; }
        public string LyContractType { get; set; }
        public string LyStyle { get; set; }
        public string LyDept { get; set; }
        public string LyDeptId { get; set; }
        public string LyPersonName { get; set; }
        public string LySex { get; set; }
        public string LyAge { get; set; }
        public string LyDegree { get; set; }
        public string LySchool { get; set; }
        public string LyMajor { get; set; }
        public string LyDiploma { get; set; }
        public string LyPosation { get; set; }
        public string LyProjectId { get; set; }
    }
}
