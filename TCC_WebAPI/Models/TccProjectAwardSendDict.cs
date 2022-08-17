using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardSendDict
    {
        public int Id { get; set; }
        public string DictTypeName { get; set; }
        public string DictName { get; set; }
        public string DictValue { get; set; }
        public string BelongDeptName { get; set; }
        public string BelongDeptCode { get; set; }
        public string BelongProjectType { get; set; }
        public int? OrderId { get; set; }
        public int? Need { get; set; }
        public string SenderRole { get; set; }
    }
}
