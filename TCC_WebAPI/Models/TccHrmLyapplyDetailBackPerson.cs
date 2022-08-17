using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmLyapplyDetailBackPerson
    {
        public int Id { get; set; }
        public string LyFormNumber { get; set; }
        public string LyDept { get; set; }
        public string LyDeptId { get; set; }
        public string LyPersonName { get; set; }
        public string LyPersonIdcardNo { get; set; }
        public string LySex { get; set; }
        public string LyComeinDate { get; set; }
        public string LyPosationName { get; set; }
        public string LyRetireDate { get; set; }
        public string LyBackStartDate { get; set; }
        public string LyBackYears { get; set; }
        public string LyBackYearsId { get; set; }
        public string LyBackEndDate { get; set; }
        public string LyBackWorkContent { get; set; }
        public string LyPosationLevel { get; set; }
        public string RzSendFlag { get; set; }
        public string RzSendFlagId { get; set; }
        public string LyPersonType { get; set; }
        public string LyNewPosation { get; set; }
        public string LyPayment { get; set; }
        public string LyBirthday { get; set; }
        public string LyAge { get; set; }
        public string HasBacked { get; set; }
        public string OldBackStartDate { get; set; }
        public string OldBackEndDate { get; set; }
        public string AttFileId { get; set; }
    }
}
