using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainTeacherInfo
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string TeacherComp { get; set; }
        public string TeacherHours { get; set; }
        public string TeacherCost { get; set; }
        public int? TrainTeacherDetailFk { get; set; }
        public string TrainTeacherDetailFkSjs { get; set; }
        public string FileId { get; set; }
    }
}
