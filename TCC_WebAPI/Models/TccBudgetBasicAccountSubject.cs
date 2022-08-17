using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicAccountSubject
    {
        public int Id { get; set; }
        public string BdgCode { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectType { get; set; }
    }
}
