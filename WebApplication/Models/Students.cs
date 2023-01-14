using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Students
    {
        public int Id { get; set; } // this represents our primary key in the table that we're going to migrate.
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Section { get; set; }
    }
}
