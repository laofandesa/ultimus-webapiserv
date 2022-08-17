using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainDonePerson
    {
        public int Id { get; set; }
        public int TrainDoneDetailFk { get; set; }
        public string PersonName { get; set; }
        public string PersonLoginName { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string Source { get; set; }
        public string SignTime { get; set; }
        public string Point { get; set; }
        public string EvaluLevel { get; set; }
        public string Paper { get; set; }
        public string EvaleTime { get; set; }
        public string EvaleDetail { get; set; }
        public string SignCount { get; set; }
        public string TrainHours { get; set; }
        public string PersonStatus { get; set; }
        public int? TrainDoneDetailChildFk { get; set; }
        public string Docm { get; set; }
        public string Report { get; set; }
    }
}
