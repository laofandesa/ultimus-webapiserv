using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoByUserId
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CswbsMName { get; set; }
        public string Zy { get; set; }
        public Guid? HumanSid { get; set; }
        public string Sfzh { get; set; }
        public string HumanName { get; set; }
        public string ManagerType { get; set; }
        public string Xmjl { get; set; }
        public string ProjectCategory { get; set; }
        public string Isfinish { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Wgsj { get; set; }
        public string ProjTypeDesc { get; set; }
        public bool? IsCost { get; set; }
        public string ProjSubTypeDesc { get; set; }
        public string ProjStatus { get; set; }
    }
}
