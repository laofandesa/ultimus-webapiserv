using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTelephoneSubsidyofHasHappened
    {
        public int? Year { get; set; }
        public string RealName { get; set; }
        public string UserIdentify { get; set; }
        public decimal? HasHappenAmount { get; set; }
    }
}
