using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExamQuestionInfo
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int? QuestionType { get; set; }
        public string CorrectAnswer { get; set; }
        public int? OrderNum { get; set; }
    }
}
