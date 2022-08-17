using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDrawingArchiveApplyDrawingDirectorySpf
    {
        public int Id { get; set; }
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
        public string FormNumberFk { get; set; }
        public string ArchiveType { get; set; }
        public string TreeFieldName { get; set; }
        public string TreeFieldId { get; set; }
        public string TreeLevel { get; set; }
        public string ParentId { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyDate { get; set; }
        public string NodeId { get; set; }
        public string State { get; set; }
        public string ProjectNo { get; set; }
        public string WorkAreaNo { get; set; }
        public string MajorCode { get; set; }
        public string DesignPersonAccount { get; set; }
        public string JhpersonAccount { get; set; }
        public string ShpersonAccount { get; set; }
        public string SdpersonAccount { get; set; }
    }
}
