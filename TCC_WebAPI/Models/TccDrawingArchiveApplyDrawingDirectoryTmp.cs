using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDrawingArchiveApplyDrawingDirectoryTmp
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string CreateDate { get; set; }
        public int? Xh { get; set; }
        public int? ParentId { get; set; }
        public string MajorId { get; set; }
        public string DrawingName { get; set; }
        public string DrawingNo { get; set; }
        public string DrawingVersion { get; set; }
        public string DrawingCount { get; set; }
        public string DrawingSize { get; set; }
        public string DrawubgCountA1 { get; set; }
        public string DesignPerson { get; set; }
        public string Jhperson { get; set; }
        public string Shperson { get; set; }
        public string Sdperson { get; set; }
        public string CompleteDate { get; set; }
        public string Remark { get; set; }
        public string ApplyDate { get; set; }
        public string FormNumber { get; set; }
    }
}
