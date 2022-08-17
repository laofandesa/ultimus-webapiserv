using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadAtt
    {
        public int Id { get; set; }
        public string AttProcessName { get; set; }
        public int? AttIncident { get; set; }
        public string AttStepName { get; set; }
        public string AttFileName { get; set; }
        public string FormNumber { get; set; }
        public int? AttUserId { get; set; }
        public string AttUserName { get; set; }
        public DateTime? AttCreateDate { get; set; }
        public int? AttOption { get; set; }
        public int? AttFileId { get; set; }
        public string AttLogin { get; set; }
        public string AfileNameId { get; set; }
        public string AfileName { get; set; }
        public string AttRequire { get; set; }
        public int? AbroadType { get; set; }
    }
}
