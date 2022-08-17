using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTasksUserChangeTemp
    {
        public int Id { get; set; }
        public string Taskid { get; set; }
        public string Assignedtouser { get; set; }
        public string Processname { get; set; }
        public int Incident { get; set; }
        public string Steplabel { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateLoginUserName { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
