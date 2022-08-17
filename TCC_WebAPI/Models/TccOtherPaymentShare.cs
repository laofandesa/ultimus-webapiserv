using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccOtherPaymentShare
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public int? ApplicationCode { get; set; }
        public int? Type { get; set; }
        public int? ShareType { get; set; }
        public int? IsDeptShare { get; set; }
        public int? IsProjShare { get; set; }
        public string SpecialDeptList { get; set; }
    }
}
