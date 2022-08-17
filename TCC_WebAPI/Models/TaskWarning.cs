using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TaskWarning
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserAccount { get; set; }
        public bool? Status { get; set; }
        public string Url { get; set; }
        public string Source { get; set; }
        public string ThirdpartyId1 { get; set; }
        public long? ThirdpartyId2 { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
