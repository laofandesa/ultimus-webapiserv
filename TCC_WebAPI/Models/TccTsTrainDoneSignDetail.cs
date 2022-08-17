using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainDoneSignDetail
    {
        public int Id { get; set; }
        public int TrainDonePersonFk { get; set; }
        public string PersonName { get; set; }
        public string PersonLoginName { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string Source { get; set; }
        public string SignTime { get; set; }
        public int? TrainDoneDetailFk { get; set; }
    }
}
