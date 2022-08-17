using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTxdocReviewOpinion
    {
        public int Id { get; set; }
        public string OpinionDept { get; set; }
        public string HuigaoPerson { get; set; }
        public string HuigaoPersonId { get; set; }
        public string ModAdvice { get; set; }
        public string SendDeptAdvice { get; set; }
        public string Demo { get; set; }
        public int Incident { get; set; }
        public DateTime? HuigaoTime { get; set; }
    }
}
