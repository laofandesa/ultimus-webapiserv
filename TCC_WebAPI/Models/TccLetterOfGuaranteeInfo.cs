using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfGuaranteeInfo
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string GuaranteeName { get; set; }
        public decimal? GuaranteeAmount { get; set; }
        public DateTime? GuaranteeDate { get; set; }
        public string CreateLoginName { get; set; }
        public string CreateRealName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? IsCollect { get; set; }
        public int? Status { get; set; }
        public string GrtLtCode { get; set; }
        public string Currency { get; set; }
        public DateTime? GrtLtStDt { get; set; }
        public DateTime? GrtLtEdDt { get; set; }
        public string OpenEnt { get; set; }
        public int? Incident { get; set; }
        public decimal? GuaranteeAmountRmb { get; set; }
        public string ProcessName { get; set; }
        public string OpenBankAcct { get; set; }
        public string OpenBankName { get; set; }
        public int? OpenType { get; set; }
        public int? IsSueForPay { get; set; }
        public decimal? SueAmt { get; set; }
        public int? SueInCash { get; set; }
        public int? IsDelay { get; set; }
        public int? OrigIsSetBack { get; set; }
        public string Judge { get; set; }
        public string Remark { get; set; }
        public DateTime? DelayEdDt { get; set; }
        public string HdId { get; set; }
        public string UnitName { get; set; }
        public decimal? GuaranteeAmountOld { get; set; }
    }
}
