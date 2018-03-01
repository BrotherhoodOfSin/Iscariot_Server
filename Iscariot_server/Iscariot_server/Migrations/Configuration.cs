namespace Iscariot_server.Migrations
{
    using Iscariot_server.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Iscariot_server.DAL.Iscariot_DB_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Iscariot_server.DAL.Iscariot_DB_Context context)
        {
            List<Schedule> temp = new List<Schedule>
            {
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 1, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 2, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 3, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 4, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 1, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 2, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 3, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "HGF", Specialty = "AJK", Section = "QWE", Term = 4, Monday_Ch = "1\t2\t3\t4", Monday_Z = "\t2\t3\t4", Tuesday_Ch = "1\t2\t\t", Tuesday_Z = "1\t2\t3\t4", Wednesday_Ch = "1\t2\t\t", Wednesday_Z = "\t\t3\t", Thursday_Ch = "1\t2\t\t", Thursday_Z = "1\t2\t\t", Friday_Ch = "1\t\t\t", Friday_Z = "1\t\t\t", Saturday_Ch ="\t\t\t", Saturday_Z="\t\t\t", Sunday_Ch ="\t\t\t", Sunday_Z = "\t\t\t" },
            };
            temp.ForEach(x => context.Schedules.Add(x));
            context.SaveChanges();
        }
    }
}
