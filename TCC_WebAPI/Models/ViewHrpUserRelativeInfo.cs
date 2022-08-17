using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHrpUserRelativeInfo
    {
        public string HrpId { get; set; }
        public string UserKey { get; set; }
        public string Relation { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Pstatus { get; set; }
        public string WorkInfo { get; set; }
        public string Title { get; set; }
        public string HomeAddress { get; set; }
        public string C7905 { get; set; }
        public string C7906 { get; set; }
    }
}
