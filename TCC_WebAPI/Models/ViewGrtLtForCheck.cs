using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewGrtLtForCheck
    {
        public int? Id { get; set; }
        public DateTime? EndDate { get; set; }
        public string ProjectCode { get; set; }
        public string ContractCode { get; set; }
        public string GuaranteeName { get; set; }
    }
}
