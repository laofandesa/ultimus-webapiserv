using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceCashierConfirmRevocationLog
    {
        public int Id { get; set; }
        public int? Fid { get; set; }
        public string PaymentCodes { get; set; }
        public DateTime? CreateTime { get; set; }
        public string OperateUser { get; set; }
        public string OperateIdnumber { get; set; }
        public string OperateRealName { get; set; }
        public string Note { get; set; }
        public string RevocationCodes { get; set; }
    }
}
