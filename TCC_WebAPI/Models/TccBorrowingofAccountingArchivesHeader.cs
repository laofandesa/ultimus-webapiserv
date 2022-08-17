using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBorrowingofAccountingArchivesHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public int? BorrowType { get; set; }
        public DateTime? BorrowStartDate { get; set; }
        public DateTime? BorrowEnddate { get; set; }
        public int? BorrowDays { get; set; }
        public string BorrowRemark { get; set; }
        public string DaManager { get; set; }
        public string DaManagerLogin { get; set; }
        public string DaManagerIdCard { get; set; }
    }
}
