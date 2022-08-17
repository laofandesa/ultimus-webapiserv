using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptWorkPerformance
    {
        public long Id { get; set; }
        public string WorkItemName { get; set; }
        public string WorkItemContent { get; set; }
        public string WorkSource { get; set; }
        public string WorkRole { get; set; }
        public string Progress { get; set; }
        public string NormalWorkHours { get; set; }
        public string OvertimeWorkHours { get; set; }
        public string SelfEvaluate { get; set; }
        public string LeaderEvaluate { get; set; }
        public long? PersonalRecordFk { get; set; }
    }
}
