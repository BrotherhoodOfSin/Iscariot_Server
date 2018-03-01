using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iscariot_server
{
    public static class CurrentMemory
    {
        public static List<(Models.LogPass User, Guid Token)> CurrentUsers { get; set; }


        static CurrentMemory()
        {
            CurrentUsers = new List<(Models.LogPass User, Guid Token)>();
        }
    }
}