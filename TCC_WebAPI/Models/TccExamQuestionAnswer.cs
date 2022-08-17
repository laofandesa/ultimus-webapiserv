using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamQuestionAnswer
    {
        public int Id { get; set; }
        public string QuestionId { get; set; }
        public string Answer { get; set; }
        public int? OrderNum { get; set; }
        public int? IsRight { get; set; }
    }
}
