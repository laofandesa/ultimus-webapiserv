using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTccHrpVoteAnswer
    {
        public string UserIp { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string WorkYear { get; set; }
        public string UserType { get; set; }
        public string DeptName { get; set; }
    }
}
