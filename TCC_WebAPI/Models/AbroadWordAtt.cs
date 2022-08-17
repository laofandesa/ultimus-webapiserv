using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AbroadWordAtt
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string AttFileName { get; set; }
        public int? AttFileId { get; set; }
        public int? AttBelong { get; set; }
    }
}
