using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPersonalAssetAtt
    {
        public int Id { get; set; }
        public string Zctm { get; set; }
        public string IsAgree { get; set; }
        public string OtherInfo { get; set; }
        public string Name { get; set; }
        public DateTime? RequstDate { get; set; }
    }
}
