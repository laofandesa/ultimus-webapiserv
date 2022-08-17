using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetOtherCodeDictionary
    {
        public int Id { get; set; }
        public string BdgCode { get; set; }
        public string OtherCode { get; set; }
        public string OtherCode2 { get; set; }
    }
}
