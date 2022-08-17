using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageHomeCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string RelationshipId { get; set; }
        public string Birthday { get; set; }
        public string WorkPlace { get; set; }
        public string PoliticalStatus { get; set; }
        public string PoliticalStatusId { get; set; }
        public string EduLevel { get; set; }
        public string EduLevelId { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public int PmFk { get; set; }
    }
}
