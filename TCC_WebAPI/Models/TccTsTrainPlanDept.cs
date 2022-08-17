using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainPlanDept
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public int? RecordStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDate { get; set; }
        public int? TrainPlanFk { get; set; }
        public string TrainYear { get; set; }
        public string TrainShenbao { get; set; }
        public string TrainShenhe { get; set; }
        public string TrainHrshenhe { get; set; }
        public string TrainShenpi { get; set; }
        public string TrainBacktime { get; set; }
        public string TrainLevel { get; set; }
    }
}
