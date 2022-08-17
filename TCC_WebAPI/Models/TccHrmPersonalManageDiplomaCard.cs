using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageDiplomaCard
    {
        public int Id { get; set; }
        public string DiplomaStyle { get; set; }
        public string DiplomaStyleId { get; set; }
        public string Diploma { get; set; }
        public string DiplomaId { get; set; }
        public string DiplomaPlace { get; set; }
        public string Major { get; set; }
        public string GraduateDate { get; set; }
        public string GraduateSchool { get; set; }
        public string EduYear { get; set; }
        public string Degree { get; set; }
        public string DegreeId { get; set; }
        public string DiplomaNo { get; set; }
        public string DegreeNo { get; set; }
        public string DegreeGetDate { get; set; }
        public int PmFk { get; set; }
    }
}
