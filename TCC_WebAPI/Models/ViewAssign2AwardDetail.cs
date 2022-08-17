using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAssign2AwardDetail
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCategory { get; set; }
        public string ProjectCode { get; set; }
        public string ReceiverLoginName { get; set; }
        public string ReceiverRealName { get; set; }
        public string UserIdentity { get; set; }
        public string Professional { get; set; }
        public string Role { get; set; }
        public decimal? Amount { get; set; }
        public string AssignFromUser { get; set; }
        public string AssignFromUserIdentity { get; set; }
        public string AssignFromUserRealName { get; set; }
        public string AwardComposed { get; set; }
        public string CanAssign { get; set; }
    }
}
