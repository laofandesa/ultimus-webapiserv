using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccManagementPersonnelBonu
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCategory { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string SelectName { get; set; }
        public string PreviousYearContractAmount { get; set; }
        public string PreviousYearDrafted { get; set; }
        public string CurrentYearContractAmount { get; set; }
        public string CurrentYearDrafted { get; set; }
        public string BussinessAward { get; set; }
        public string BussinessSubsidy { get; set; }
        public string BussinessTotal { get; set; }
        public string IsFanPin { get; set; }
        public string UserIdentity { get; set; }
        public string PersonLoginName { get; set; }
    }
}
