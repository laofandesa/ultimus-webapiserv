using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjResearchProject
    {
        public long Sid { get; set; }
        public string PProjId { get; set; }
        public string PProjName { get; set; }
        public string ProjId { get; set; }
        public string ProjName { get; set; }
        public string TopicStatus { get; set; }
    }
}
