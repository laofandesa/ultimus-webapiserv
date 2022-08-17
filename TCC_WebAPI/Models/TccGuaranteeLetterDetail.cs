using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterDetail
    {
        public string DetailId { get; set; }
        public string HdId { get; set; }
        public bool IsCollect { get; set; }
        public string GrtLtType { get; set; }
        public string GrtLtCode { get; set; }
        public string GrtLtCurrency { get; set; }
        public decimal GrtLtAmt { get; set; }
        public decimal GrtLtRmbAmt { get; set; }
        public int OpenType { get; set; }
        public string OpenBank { get; set; }
        public string OpenEnt { get; set; }
        public string GrtLtBen { get; set; }
        public string GrtLtDesc { get; set; }
        public decimal GrtLtGuaAmt { get; set; }
        public string GrtLtDeliver { get; set; }
        public DateTime? DeliverDate { get; set; }
        public string GrtLtReviewDesc { get; set; }
        public int? GrtLtReviewed { get; set; }
        public string DtDesc { get; set; }
        public DateTime? GrtLtEdDt { get; set; }
        public DateTime? GrtLtStDt { get; set; }
        public string GrtLtRange { get; set; }
    }
}
