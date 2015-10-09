using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TA_BH_MVC5.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}