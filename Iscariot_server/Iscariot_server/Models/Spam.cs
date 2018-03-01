using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iscariot_server.Models
{
    public class Spam
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public string Section { get; set; }
        public int Term { get; set; }
    }
}