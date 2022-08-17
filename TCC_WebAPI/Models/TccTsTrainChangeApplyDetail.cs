using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainChangeApplyDetail
    {
        public int Id { get; set; }
        public string FormNumberFk { get; set; }
        public string TrainType { get; set; }
        public string TrainObject { get; set; }
        public string TrainContent { get; set; }
        public string TrainTarget { get; set; }
        public string TrainStyle { get; set; }
        public string TrainRspPerson { get; set; }
        public string TrainRspPersonId { get; set; }
        public string TrainRspDept { get; set; }
        public string TrainRspDeptNo { get; set; }
        public string TrainHlepDept { get; set; }
        public string TrainHlepDeptNo { get; set; }
        public string TrainTeacherSource { get; set; }
        public string TrainTeacher { get; set; }
        public string TrainDate { get; set; }
        public double? TrainHours { get; set; }
        public int? TrainStudsNum { get; set; }
        public string TrainExamKind { get; set; }
        public int? TrainPlanDeptFk { get; set; }
        public string TrainPlanLevel { get; set; }
        public double? TrainCost { get; set; }
        public string TrainStatus { get; set; }
        public string TrainOption { get; set; }
        public string TrainRemark { get; set; }
        public string ApplyLoginUser { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int? TrainDetailId { get; set; }
    }
}
