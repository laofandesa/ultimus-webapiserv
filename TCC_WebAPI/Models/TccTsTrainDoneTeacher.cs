using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainDoneTeacher
    {
        public int Id { get; set; }
        public int? TrainDoneDetailFk { get; set; }
        public string PersonName { get; set; }
        public string PersonLoginName { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string TrainHours { get; set; }
        public string TrainPrice { get; set; }
        public string TrainCost { get; set; }
    }
}
