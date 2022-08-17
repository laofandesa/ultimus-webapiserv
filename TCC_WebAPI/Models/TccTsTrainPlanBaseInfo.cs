using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainPlanBaseInfo
    {
        public int Id { get; set; }
        public string TrainYear { get; set; }
        public string TrainStartTime { get; set; }
        public string TrainStatus { get; set; }
        public string TrainStartPersonName { get; set; }
        public string TrainStartPersonLoginName { get; set; }
        public string FormNumber { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDate { get; set; }
    }
}
