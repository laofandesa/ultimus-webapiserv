using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicAuthorityDictionary20181122
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageDescription { get; set; }
        public int? Authority { get; set; }
        public string Description { get; set; }
        public int? Weight { get; set; }
    }
}
