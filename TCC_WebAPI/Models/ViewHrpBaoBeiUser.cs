using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHrpBaoBeiUser
    {
        public int? Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string HrpId { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string Sex { get; set; }
        public string BornDate { get; set; }
        public string WorkInfo { get; set; }
        public string AbroadTask { get; set; }
        public string GroupInfo { get; set; }
        public string Pstatus { get; set; }
        public string Phealth { get; set; }
    }
}
