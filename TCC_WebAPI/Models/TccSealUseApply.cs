using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSealUseApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyType { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string SealCount { get; set; }
        public string SealType { get; set; }
        public string OtherSeal { get; set; }
        public string SendComp { get; set; }
        public string ApplyUse { get; set; }
        public string UseType { get; set; }
        public string SpecialSealType { get; set; }
        public string HtType { get; set; }
        public string MainContent { get; set; }
        public string HtName { get; set; }
        public string HtPrice { get; set; }
        public string HtBothSideName { get; set; }
        public string HtContent { get; set; }
        public string HtNum { get; set; }
        public string IsThirdPart { get; set; }
        public string FormNumber { get; set; }
        public string SealDept { get; set; }
        public string SealDeptNo { get; set; }
        public DateTime? MsgSendTime { get; set; }
        public int? MsgSendCts { get; set; }
        public string SecretSealStatus { get; set; }
        public string SecretSealRemark { get; set; }
        public string ThirdPartId { get; set; }
        public string ThirdPartSealType { get; set; }
        public string ThirdPartUseType { get; set; }
        public string SqIdcardNo { get; set; }
        public string SqType { get; set; }
        public string SqStartDate { get; set; }
        public string SqEndDate { get; set; }
        public string SqNeedSeal { get; set; }
        public string SqNeedSealCount { get; set; }
        public string SqJydept { get; set; }
        public string SqReason { get; set; }
        public string SqContent { get; set; }
        public string SqNumber { get; set; }
        public string SqPerson { get; set; }
        public string SqDonePerson { get; set; }
        public string SqNeedGz { get; set; }
    }
}
