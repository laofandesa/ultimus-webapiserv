using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class SpecialFare
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public string ApplyUser { get; set; }
        public string UserName { get; set; }
        public string UserKey { get; set; }
        public int? ApplyType { get; set; }
        public int? DriCarmiles { get; set; }
        public decimal? DriEverymileStandard { get; set; }
        public decimal? DrMileMoney { get; set; }
        public int? BusinessDays { get; set; }
        public decimal? BusinessStandard { get; set; }
        public decimal? BusinessMoney { get; set; }
        public int? WeekDays { get; set; }
        public decimal? WeekStandard { get; set; }
        public decimal? WeekMoney { get; set; }
        public int? EveryDays { get; set; }
        public decimal? EveryDaysStandard { get; set; }
        public decimal? EveryDaysMoney { get; set; }
        public int? WholeDays { get; set; }
        public decimal? WholeDaysStandard { get; set; }
        public decimal? WholeDaysMoney { get; set; }
        public int? HoliDays { get; set; }
        public decimal? HoliDaysStandard { get; set; }
        public decimal? HoliDaysMoney { get; set; }
        public int? AllDays { get; set; }
        public decimal? AllDaysStandard { get; set; }
        public decimal? AllDaysMoney { get; set; }
        public int? Nights { get; set; }
        public decimal? NightsStandard { get; set; }
        public decimal? NightsMoney { get; set; }
        public int? ProDays { get; set; }
        public decimal? ProDaysStandard { get; set; }
        public decimal? ProDaysMoney { get; set; }
        public int? ProHolidaydays { get; set; }
        public decimal? ProHolidayStandard { get; set; }
        public decimal? ProHolidayMoney { get; set; }
        public int? Resdays { get; set; }
        public decimal? ResdaysStandard { get; set; }
        public decimal? ResdaysMoney { get; set; }
        public int? TutorMonth { get; set; }
        public decimal? TutorMonthStandard { get; set; }
        public decimal? TutorMonthMoney { get; set; }
        public int? EditorMany { get; set; }
        public decimal? EditorManyStandard { get; set; }
        public decimal? EditorManyMoney { get; set; }
        public decimal? EditorMoney { get; set; }
        public int? OtherLine { get; set; }
        public decimal? OtherLineStandard { get; set; }
        public decimal? OtherLineMoney { get; set; }
        public decimal? Allmoney { get; set; }
        public DateTime? TimeMonth { get; set; }
    }
}
