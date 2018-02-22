using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Iscariot_server.Models
{
    public class LogPass
    {
        [Key]
        public string Login { get; set; }
        public string PassHash { get; set; }
        public string Email { get; set; }
        public bool NeedAuth { get; set; }
    }
}