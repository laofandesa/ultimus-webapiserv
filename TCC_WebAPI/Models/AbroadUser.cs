using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AbroadUser
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLogin { get; set; }
        public int? AbroadType { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VisitDays { get; set; }
        public string Tvcountry { get; set; }
        public string RoadInfo { get; set; }
        public string VisaType { get; set; }
        public string VisaTypeNo { get; set; }
        public string VisaOther { get; set; }
        public DateTime? VisaValid { get; set; }
        public string VisaNum { get; set; }
        public string VisaSec { get; set; }
        public string VisaSecInfo { get; set; }
        public string PassportType { get; set; }
        public string PassportTypeNo { get; set; }
        public string PassportCode { get; set; }
        public string PassportReason { get; set; }
        public DateTime? PassportValid { get; set; }
        public DateTime? ReturnPaperDate { get; set; }
        public int? AssignNum { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string Name { get; set; }
        public string PinYinName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HrpId { get; set; }
        public string UserKey { get; set; }
        public string Mobile { get; set; }
        public decimal? PostGrade { get; set; }
        public string Post { get; set; }
        public string Title { get; set; }
        public DateTime? BornDate { get; set; }
        public string BornPlace { get; set; }
        public int? Sex { get; set; }
        public int? Age { get; set; }
        public int? IsNeedPassPort { get; set; }
        public int? IsVsfirst { get; set; }
        public string CompId { get; set; }
        public string CompName { get; set; }
        public string Position { get; set; }
        public string VisitInfo { get; set; }
        public string VisaCode { get; set; }
        public string Embassy { get; set; }
        public string RemarkInfo { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? TvsubmitDate { get; set; }
        public DateTime? BorrowDate { get; set; }
        public string ContractStatus { get; set; }
        public string Countersign { get; set; }
        public string Nationality { get; set; }
        public string IsHaveWorkVisa { get; set; }
        public int? UserType { get; set; }
        public int? UserFlag { get; set; }
        public string VisaCity { get; set; }
    }
}
