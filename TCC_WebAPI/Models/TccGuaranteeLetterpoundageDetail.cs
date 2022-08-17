using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterpoundageDetail
    {
        public int Id { get; set; }
        public int Hdid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectCode { get; set; }
        public string LoiPoundage { get; set; }
        public string GrtLtRmbAmt { get; set; }
        public DateTime? Timeofpayment { get; set; }
        public string GrtLtCode { get; set; }
        public string IsCollect { get; set; }
        public string GrtLtCurrency { get; set; }
        public string Papername { get; set; }
        public string GrtLtAmt { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string Contractname { get; set; }
        public string Parities { get; set; }
        public string Currency { get; set; }
        public string RequestRealName { get; set; }
        public string Glid { get; set; }
        public string GrtLtType { get; set; }
        public int? Isjq { get; set; }
    }
}
