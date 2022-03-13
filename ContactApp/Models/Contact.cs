using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Number { get; set; }
        public string Email { get; set; }
    }
}