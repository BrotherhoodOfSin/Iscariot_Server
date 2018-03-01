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
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 1, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 2, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 3, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PMI", Section = "MIM", Term = 4, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 1, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 2, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 3, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
                new Schedule{Id=Guid.NewGuid(), Faculty = "FMF", Specialty = "PIL", Section = "MIM", Term = 4, Monday_Ch = "1,2,3", Monday_Z = "2,3,4", Tuesday_Ch = "1,2", Tueday_Z = "1,2,3,4", Wednesday_Ch = "1,2", Wednesday_Z = "3", Thursday_Ch = "1,2", Thursday_Z = "1,2", Friday_Ch = "1", Friday_Z = "1", Saturday_Ch ="", Saturday_Z="", Sunday_Ch ="", Sunday_Z = "" },
            };
            temp.ForEach(x => context.Schedules.Add(x));
            context.SaveChanges();
        }
    }
}
