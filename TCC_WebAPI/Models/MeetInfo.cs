using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MeetInfo
    {
        public int MeetId { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string MeetingCode { get; set; }
        public string MeetRoom { get; set; }
        public string RoomCode { get; set; }
        public string ServiceNeed { get; set; }
        public string ServiceCode { get; set; }
        public string FiledNeed { get; set; }
        public string EquNeed { get; set; }
        public string EquCode { get; set; }
        public int? IsHefu { get; set; }
        public string HfContent { get; set; }
        public string VoteContents { get; set; }
        public string VoteCode { get; set; }
        public int? VoteType { get; set; }
        public string VoteOption { get; set; }
        public DateTime? VoteDeadline { get; set; }
        public decimal? MeetFare { get; set; }
        public decimal? ServiceFare { get; set; }
        public decimal? RoomFare { get; set; }
        public string Remark { get; set; }
    }
}
