using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccUserDefinedApplicationForAwardLog
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public string LoginName { get; set; }
        public string RealName { get; set; }
        public string OpDesc { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
