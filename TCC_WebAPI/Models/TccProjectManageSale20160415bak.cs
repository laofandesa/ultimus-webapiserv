using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectManageSale20160415bak
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? AmountYb { get; set; }
        public string Currency { get; set; }
        public string Digest { get; set; }
        public string Item6 { get; set; }
        public byte[] Recid { get; set; }
    }
}
