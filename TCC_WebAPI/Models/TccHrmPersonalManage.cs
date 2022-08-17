using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManage
    {
        public int Id { get; set; }
        public string ComeInDate { get; set; }
        public string DeptName { get; set; }
        public string UserName { get; set; }
        public string IdNumber { get; set; }
        public string RecordStatus { get; set; }
        public string LanguageCardStatus { get; set; }
        public string PartyCardStatus { get; set; }
        public string HomeCardStatus { get; set; }
        public string ResumeCardStatus { get; set; }
        public string PhoneCardStatus { get; set; }
        public string BankCardStatus { get; set; }
        public string PartyCardSubmitDate { get; set; }
        public string LanguageCardSubmitDate { get; set; }
    }
}
