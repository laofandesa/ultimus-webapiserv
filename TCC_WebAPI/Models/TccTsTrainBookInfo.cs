using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainBookInfo
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int? BookNum { get; set; }
        public string BookCost { get; set; }
        public int? TrainTeacherDetailFk { get; set; }
        public string TrainTeacherDetailFkSjs { get; set; }
    }
}
