using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHrpUserInfo
    {
        public long? Id { get; set; }
        public string DeptNo { get; set; }
        public string CompId { get; set; }
        public DateTime? BornDate { get; set; }
        public string HrpId { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string Post { get; set; }
        public string Title { get; set; }
        public string Sex { get; set; }
        public int? Age { get; set; }
        public string DeptName { get; set; }
        public string A0100 { get; set; }
        public string E1714 { get; set; }
        public decimal? PostGrade { get; set; }
        public string E1701 { get; set; }
        public string PostName { get; set; }
        public string PostType { get; set; }
        public string BornPlace { get; set; }
    }
}
