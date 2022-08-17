using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPersonalAsset
    {
        public int Id { get; set; }
        public string Zctm { get; set; }
        public string Szctm { get; set; }
        public string Flmc { get; set; }
        public string Zcmc { get; set; }
        public string Defined6 { get; set; }
        public string KpPp { get; set; }
        public string Sn { get; set; }
        public string ZcStatus { get; set; }
        public string YwStatus { get; set; }
        public string KyStatus { get; set; }
        public string StPosition { get; set; }
        public string BkInfo { get; set; }
        public string BkInfo1 { get; set; }
        public string Fwfs { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string UserKey { get; set; }
        public string OtherInfo { get; set; }
        public string IsAgree { get; set; }
        public string Name { get; set; }
        public DateTime? RequstDate { get; set; }
    }
}
