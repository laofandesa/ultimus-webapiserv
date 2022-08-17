using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccManagementAwardsDetailsTest
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string PreviousYearContractAmount { get; set; }
        public string PreviousYearDrafted { get; set; }
        public string CurrentYearContractAmount { get; set; }
        public string CurrentYearDrafted { get; set; }
    }
}
