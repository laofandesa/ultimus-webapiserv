using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDrawingArchiveApplyPressurePipe
    {
        public int Id { get; set; }
        public string FormNumberFk { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyDate { get; set; }
        public string PipeNo { get; set; }
        public string DraftNo { get; set; }
        public string Ppkind { get; set; }
        public string DesignDate { get; set; }
        public string Size { get; set; }
        public string MainbodyMt { get; set; }
        public string Remark { get; set; }
        public string Ppmedium { get; set; }
        public string Ppc { get; set; }
        public string Ppmpa { get; set; }
        public string DesignPerson { get; set; }
        public string Jdperson { get; set; }
        public string Shperson { get; set; }
        public string Sdperson { get; set; }
        public string SealCount { get; set; }
        public string PipeLong { get; set; }
    }
}
