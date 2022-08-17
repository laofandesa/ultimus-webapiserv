using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPutProjectTurnoverRecordChangeMain
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string ProcessName { get; set; }
        public string BankCard { get; set; }
        public int? ModifyType { get; set; }
        public string ModifyTypeName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestUser { get; set; }
        public string RequestUserLoginName { get; set; }
        public string RequestUserIdentityId { get; set; }
        public string DpetName { get; set; }
        public string DeptCode { get; set; }
        public string FormNumber { get; set; }
        public int? ChangeType { get; set; }
        public int? ChangeQuotaType { get; set; }
        public DateTime? EnabledEndDate { get; set; }
        public string NewBankCard { get; set; }
        public string NewCardHolder { get; set; }
        public string NewCardHolderLoginname { get; set; }
        public string NewCardHolderUserIdentityId { get; set; }
        public string NewReimbursementManager { get; set; }
        public string NewReimbursementManagerLoginname { get; set; }
        public string NewReimbursementManagerUserIdentityId { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessTime { get; set; }
        public int? NewBankCardType { get; set; }
        public int? ApplyType { get; set; }
        public string Remarks { get; set; }
        public string NewBankName { get; set; }
        public int? AccountId { get; set; }
    }
}
