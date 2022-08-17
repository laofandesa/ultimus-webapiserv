using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRegistrationSubsidyDetail
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string ApplyRealname { get; set; }
        public string ApplyIdNumber { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string ApplyLoginName { get; set; }
        public string RealName { get; set; }
        public string Useridentity { get; set; }
        public decimal? Money { get; set; }
        public string IsReimburse { get; set; }
        public string Remark { get; set; }
    }
}
