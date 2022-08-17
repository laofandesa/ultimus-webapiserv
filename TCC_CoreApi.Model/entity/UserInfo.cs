using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_CoreApi.Model.entity
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public virtual List<Articles> Articles { get; set; }
    }

    public class Articles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string summary { get; set; }
        public virtual UserInfo User { get; set; }

    }
}
