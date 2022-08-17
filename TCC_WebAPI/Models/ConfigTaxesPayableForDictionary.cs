using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigTaxesPayableForDictionary
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string RateValue { get; set; }
        public string OsubjectCode { get; set; }
        public string UserFor { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
    }
}
