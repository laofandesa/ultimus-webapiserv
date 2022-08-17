using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrpVoteQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; }
        public string UserType { get; set; }
        public int? SerialNum { get; set; }
        public int? IsDelete { get; set; }
    }
}
