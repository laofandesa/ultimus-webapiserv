using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryPerson
    {
        public int Id { get; set; }
        public int? StepInfoFk { get; set; }
        public string UserName { get; set; }
        public string UserAccount { get; set; }
        public string UserIdcardNo { get; set; }
    }
}
