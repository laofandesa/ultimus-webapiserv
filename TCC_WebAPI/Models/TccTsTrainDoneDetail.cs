using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainDoneDetail
    {
        public int Id { get; set; }
        public string TrainRspDept { get; set; }
        public string TrainRspDeptNo { get; set; }
        public string TrainStartDate { get; set; }
        public string TrainEndDate { get; set; }
        public string TrainPlanOption { get; set; }
        public string TrainContent { get; set; }
        public string TrainContentChild { get; set; }
        public string TrainRspPerson { get; set; }
        public string TrainRspPersonId { get; set; }
        public double? TrainHours { get; set; }
        public string TrainStyle { get; set; }
        public string IsOutTeacher { get; set; }
        public string TrainTeacher { get; set; }
        public string TrainTeacherSource { get; set; }
        public double? TrainTeacherCost { get; set; }
        public string TrainExamKind { get; set; }
        public string HasZhengShu { get; set; }
        public string ZhengShuName { get; set; }
        public string ZhengShuCmp { get; set; }
        public string TrainDoneType { get; set; }
        public string TrainStatus { get; set; }
        public string TrainDoneUserName { get; set; }
        public string TrainDoneUserLoginName { get; set; }
        public string TrainDoneUserDept { get; set; }
        public string TrainDoneUserDeptNo { get; set; }
        public string TrainDoneSubmitTime { get; set; }
        public int? TrainPlanFk { get; set; }
        public string TrainLevel { get; set; }
        public int? TrainDoneIdFather { get; set; }
        public string BsFormNumber { get; set; }
        public string BsIncident { get; set; }
    }
}
