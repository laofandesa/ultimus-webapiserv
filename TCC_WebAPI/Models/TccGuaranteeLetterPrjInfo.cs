using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterPrjInfo
    {
        public string PrjId { get; set; }
        public string HdId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }

        public virtual TccGuaranteeLetterHeader Hd { get; set; }
    }
}
