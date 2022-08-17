using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardSenderHistroy
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string UserIdentityId { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string SenderRealName { get; set; }
        public string SenderLoginName { get; set; }
        public string SenderIdentityid { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Pid { get; set; }
    }
}
