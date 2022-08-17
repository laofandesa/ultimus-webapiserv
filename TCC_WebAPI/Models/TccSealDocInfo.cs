using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSealDocInfo
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string FileName { get; set; }
        public string FileNum { get; set; }
        public string SealNum { get; set; }
    }
}
