using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDriverOverTime
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public decimal? OthercompanySum { get; set; }
        public decimal? OwncompanySum { get; set; }
        public string TimeMonth { get; set; }
        public decimal? AllSum { get; set; }
        public string RequestUserIdentity { get; set; }
        public string PayBankName { get; set; }
        public string PayCheque { get; set; }
        public string PayBankCode { get; set; }
        public string BussinessCard { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public int? Voucherid { get; set; }
        public string PaymentType { get; set; }
        public decimal? PayMoney { get; set; }
        public string ConfirmFinaceDate { get; set; }
        public string ConfirmStatus { get; set; }
        public string Transactor { get; set; }
        public int? BusinessObject { get; set; }
        public string FinanceAultierName { get; set; }
        public string FinanceAultierLoginName { get; set; }
        public string FinanceAultierDate { get; set; }
    }
}
