using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjBudgetProcessInfo
    {
        public int Pbpformsid { get; set; }
        public int MSid { get; set; }
        public long Sid { get; set; }
        public string Ver { get; set; }
        public DateTime? VerDate { get; set; }
        public string Processname { get; set; }
        public int? Incident { get; set; }
        public string ReqHuman { get; set; }
        public string ReqDept { get; set; }
        public long? Iyear { get; set; }
    }
}
