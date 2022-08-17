using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPayMedicalInsuranceFeeDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ApplyPersonLogin { get; set; }
        public string PersonName { get; set; }
        public string PersonUseridentity { get; set; }
        public string PersonDeptCode { get; set; }
        public string PersonDeptName { get; set; }
        public decimal? Amount { get; set; }
    }
}
