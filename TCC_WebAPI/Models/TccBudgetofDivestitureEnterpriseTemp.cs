using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetofDivestitureEnterpriseTemp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string SerialNum { get; set; }
        public string ApplyUnit { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAdress { get; set; }
        public string ProjectCategory { get; set; }
        public DateTime? SignDate { get; set; }
        public decimal? BudgetAmout { get; set; }
        public decimal? RaisenAmout { get; set; }
        public decimal? SubsidyAmout { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
    }
}
