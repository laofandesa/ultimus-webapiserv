using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class SpecialFareStandard
    {
        public int Id { get; set; }
        public decimal? DriEverymileStandard { get; set; }
        public decimal? DriWeekStandard { get; set; }
        public decimal? DriEveryDaysStandard { get; set; }
        public decimal? DriWholeDaysStandard { get; set; }
        public decimal? DriHoliDaysStandard { get; set; }
        public decimal? DriAllDaysStandard { get; set; }
        public decimal? DriNightsStandard { get; set; }
        public decimal? ProDaysStandard { get; set; }
        public string ProHolidayStandard { get; set; }
        public decimal? ResdaysStandard { get; set; }
        public decimal? TutorMonthStandard { get; set; }
        public string EditorManyStandard { get; set; }
        public string OtherStandard { get; set; }
    }
}
