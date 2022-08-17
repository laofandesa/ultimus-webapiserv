using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPhoneModifyInfo
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string ModifyType { get; set; }
        public string ModityReason { get; set; }
        public string PhoneType { get; set; }
        public string Nettype { get; set; }
        public string PhoneNo { get; set; }
        public string NewNettype { get; set; }
        public string FareTypeText { get; set; }
        public int? FareType { get; set; }
        public string SphoneName { get; set; }
        public string SphoneUserKey { get; set; }
        public string NphoneName { get; set; }
        public string NphoneUserKey { get; set; }
        public string NroomNo { get; set; }
        public string NseatNo { get; set; }
        public string NdeptName { get; set; }
        public string NdeptNo { get; set; }
        public string ApplyLogin { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
    }
}
