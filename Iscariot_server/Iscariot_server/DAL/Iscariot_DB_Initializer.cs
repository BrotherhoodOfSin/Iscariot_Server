using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Iscariot_server.Models;

namespace Iscariot_server.DAL
{
    public class Iscariot_DB_Initializer : DropCreateDatabaseIfModelChanges<Iscariot_DB_Context>
    {
        protected override void Seed(Iscariot_DB_Context context)
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
        }
    }
}