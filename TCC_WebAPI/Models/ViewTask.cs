using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTask
    {
        public int Id { get; set; }
        public string TaskId { get; set; }
        public string PName { get; set; }
        public int? Incident { get; set; }
        public string SName { get; set; }
        public string TUser { get; set; }
        public DateTime? TBeginTime { get; set; }
        public DateTime? TEndTime { get; set; }
        public string IUser { get; set; }
        public DateTime? IBeginTime { get; set; }
        public int? TStatus { get; set; }
        public string Summary { get; set; }
        public string Params { get; set; }
        public string Source { get; set; }
    }
}
