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
        static Timer PeriodicTask;

        static CurrentMemory()
        {
            CurrentUsers = new List<(Models.LogPass User, Guid Token, DateTime LogTime)>();
            PeriodicTask = new Timer()
            {
                //Interval = 2 * 60 * 60 * 1000,
                Interval = 60 * 1000,
                AutoReset = true
            };
            PeriodicTask.Elapsed += Periodics;
            PeriodicTask.Start();
        }

        private static void Periodics(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < CurrentUsers.Count; i++)
                //if (DateTime.Now - CurrentUsers[i].LogTime >= TimeSpan.FromHours(2))
                if (DateTime.Now - CurrentUsers[i].LogTime >= TimeSpan.FromMinutes(1))
                    CurrentUsers.RemoveAt(i--);
        }
    }
}