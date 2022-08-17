using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccEmployeePreInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string CheckId { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string UserKey { get; set; }
        public string HrpId { get; set; }
        public string HrpType { get; set; }
        public int? Sex { get; set; }
        public DateTime? BornDate { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public string GraduateYear { get; set; }
        public string College { get; set; }
        public string Major { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string SignYear { get; set; }
        public DateTime? EnterDate { get; set; }
        public string RemarkInfo { get; set; }
        public int? DepNum { get; set; }
        public int? DepAgreeNum { get; set; }
    }
}
