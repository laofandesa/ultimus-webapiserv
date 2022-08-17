using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPartyValueSubmit
    {
        public int Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public string SurveyAccount { get; set; }
    }
}
