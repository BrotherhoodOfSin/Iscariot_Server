using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Iscariot_server.Models;

namespace Iscariot_server.DAL
{
    public class Iscariot_DB_Context : DbContext
    {
        public Iscariot_DB_Context() :base("Iscariot_DB_Context")
        {

        }

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<LogPass> LogPasses { get; set; }
        public DbSet<Spam> Spams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}