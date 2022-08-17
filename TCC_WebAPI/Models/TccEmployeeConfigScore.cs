using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccEmployeeConfigScore
    {
        public int ScoreId { get; set; }
        public string ScoreIdtype { get; set; }
        public string ScoreIdtitle { get; set; }
        public string ScoreIdinfo { get; set; }
        public double? ScoreScore { get; set; }
        public int? ScoreGroup { get; set; }
        public int? SortOrder { get; set; }
        public int? ScoreType { get; set; }
    }
}
