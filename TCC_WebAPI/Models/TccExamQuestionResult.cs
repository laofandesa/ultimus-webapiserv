using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamQuestionResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string DeptNo { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public double? Score { get; set; }
    }
}
