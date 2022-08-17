using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainTeacherApply
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDate { get; set; }
        public string TotalCost { get; set; }
        public string TrainOption { get; set; }
        public string ApplyType { get; set; }
        public string ApplyPhone { get; set; }
        public string TrainContent { get; set; }
        public string TrainTarget { get; set; }
        public string TrainObject { get; set; }
        public string StudentNum { get; set; }
        public string TrainStartTime { get; set; }
        public string TrainEndTime { get; set; }
        public string TeacherName { get; set; }
        public string TeacherComp { get; set; }
        public string TeacherHours { get; set; }
        public string BookName { get; set; }
        public int? BookNum { get; set; }
        public string BookPrice { get; set; }
        public string BookCost { get; set; }
        public string TeacherCost { get; set; }
        public string ExamKind { get; set; }
        public string TrainType { get; set; }
        public string TeacherSource { get; set; }
        public string TrainLevel { get; set; }
    }
}
