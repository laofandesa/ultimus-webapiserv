using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageResumeCard
    {
        public int Id { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public string WorkPlace { get; set; }
        public string WorkDept { get; set; }
        public string WorkContent { get; set; }
        public string KnowPerson { get; set; }
        public int PmFk { get; set; }
    }
}
