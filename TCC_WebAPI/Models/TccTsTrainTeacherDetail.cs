using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainTeacherDetail
    {
        public int Id { get; set; }
        public string TeacherType { get; set; }
        public string TrainContent { get; set; }
        public string TeacherSourceDept { get; set; }
        public string TrainStartTime { get; set; }
        public string TrainEndTime { get; set; }
        public string TeacherCost { get; set; }
        public string TrainObject { get; set; }
        public string StudentNum { get; set; }
        public int? TrainPlanFk { get; set; }
        public int? TrainDoneFk { get; set; }
        public int? TrainTeacherApplyFk { get; set; }
        public string TrainOption { get; set; }
        public int? TeacherStatus { get; set; }
        public string FormNumber { get; set; }
        public string TrainTarget { get; set; }
        public string IdSjs { get; set; }
    }
}
