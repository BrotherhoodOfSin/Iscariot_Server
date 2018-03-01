using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

namespace Iscariot_server
{
    public static class CurrentMemory
    {
        public static List<(Models.LogPass User, Guid Token, DateTime LogTime)> CurrentUsers { get; set; }
        static Timer h;

        static CurrentMemory()
        {
            CurrentUsers = new List<(Models.LogPass User, Guid Token, DateTime LogTime)>();
        }
    }
}