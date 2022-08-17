using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsPartyTrainResult
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string DeptName { get; set; }
        public string PartyGroupName { get; set; }
        public string TrainStartTime { get; set; }
        public string TrainEndTime { get; set; }
        public string TrainContent { get; set; }
        public string TrainHours { get; set; }
        public string TrainStyle { get; set; }
        public string Teacher { get; set; }
        public string TeacherHours { get; set; }
        public DateTime? CreatDate { get; set; }
    }
}
