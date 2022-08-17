using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccIncomeAwardDetail
    {
        public int Id { get; set; }
        public string Dept { get; set; }
        public string UserIdentityId { get; set; }
        public string UserName { get; set; }
        public string Q { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public string AwardType { get; set; }
        public string AwardName { get; set; }
        public string AwardComposed { get; set; }
        public string AwardComposedCode { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Summary { get; set; }
        public decimal? AwardMoney { get; set; }
        public string Pro { get; set; }
        public string ProjectManagerName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectIdCardNo { get; set; }
        public decimal? Qmoney { get; set; }
        public decimal? AllPayMonty { get; set; }
        public decimal? SaveMoney { get; set; }
    }
}
