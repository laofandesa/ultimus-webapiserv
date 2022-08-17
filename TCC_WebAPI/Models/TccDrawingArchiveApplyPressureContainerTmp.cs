using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDrawingArchiveApplyPressureContainerTmp
    {
        public int Id { get; set; }
        public string EquName { get; set; }
        public string DraftNo { get; set; }
        public string Pclevel { get; set; }
        public string Pckind { get; set; }
        public string EquCount { get; set; }
        public string Pcmpa { get; set; }
        public string Pcc { get; set; }
        public string Pcmedium { get; set; }
        public string MainbodyMt { get; set; }
        public string Size { get; set; }
        public string DesignPerson { get; set; }
        public string Jdperson { get; set; }
        public string Shperson { get; set; }
        public string Sdperson { get; set; }
        public string DesignDate { get; set; }
        public string EquWeight { get; set; }
        public string Remark { get; set; }
        public string SealCount { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string CreateDate { get; set; }
    }
}
