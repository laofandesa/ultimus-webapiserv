using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsDictShouldDoneHour
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int? TrainCount { get; set; }
        public int? TrainYear { get; set; }
    }
}
