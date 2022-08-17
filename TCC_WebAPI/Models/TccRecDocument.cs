using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRecDocument
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FromComp { get; set; }
        public string FromDocNo { get; set; }
        public string DocDegree { get; set; }
        public string DocType { get; set; }
        public string RecNo { get; set; }
        public DateTime? RecDate { get; set; }
        public string DocTitle { get; set; }
        public string ChiefDept { get; set; }
        public string ChiefDeptNo { get; set; }
        public string ChiefLerderName { get; set; }
        public string ChiefLerderAccount { get; set; }
        public string ChiefUserName { get; set; }
        public string ChiefUserAccount { get; set; }
        public string SubDept { get; set; }
        public string SubDeptNo { get; set; }
        public string SubLeaderName { get; set; }
        public string SubLeaderAccount { get; set; }
        public string SubUserName { get; set; }
        public string SubUserAccount { get; set; }
    }
}
