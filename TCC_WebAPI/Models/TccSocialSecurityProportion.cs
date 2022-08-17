using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSocialSecurityProportion
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? CPensionInsurance { get; set; }
        public decimal? PPensionInsurance { get; set; }
        public decimal? CMedicalInsurance { get; set; }
        public decimal? PMedicalInsurance { get; set; }
        public decimal? CUnemploymentInsurance { get; set; }
        public decimal? PUnemploymentInsurance { get; set; }
        public decimal? CInjuryInsurance { get; set; }
        public decimal? CMaternityInsurance { get; set; }
        public decimal? CTotalProportion { get; set; }
        public decimal? PTotalProportion { get; set; }
        public decimal? CFund { get; set; }
        public decimal? PFund { get; set; }
        public decimal? Annuity { get; set; }
    }
}
