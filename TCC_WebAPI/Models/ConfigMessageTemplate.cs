using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigMessageTemplate
    {
        public int MtId { get; set; }
        public string MtCode { get; set; }
        public string MtTitle { get; set; }
        public string MtContent { get; set; }
        public int? MtType { get; set; }
    }
}
