using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageLanguageCard
    {
        public int Id { get; set; }
        public string LanguageKind { get; set; }
        public string LanguageKindId { get; set; }
        public string LanguageLevel { get; set; }
        public string LanguageLevelId { get; set; }
        public string LanguageScore { get; set; }
        public string GetDate { get; set; }
        public int PmFk { get; set; }
    }
}
