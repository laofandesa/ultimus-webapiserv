using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class SecToProject
    {
        public int Id { get; set; }
        public string SecUser { get; set; }
        public string SecName { get; set; }
        public string Projector { get; set; }
        public string ProjectoId { get; set; }
    }
}
