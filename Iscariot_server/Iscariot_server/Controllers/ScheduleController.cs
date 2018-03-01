using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Iscariot_server.DAL;

namespace Iscariot_server.Controllers
{
    public class ScheduleController : ApiController
    {
        //Внимание - ты сейчас немножкол удивишься
        static Iscariot_DB_Context db = new Iscariot_DB_Context();
        public JArray Get()
        {
            //List<string> facs = db.Database.ExecuteSqlCommand("SELECT Faculty FROM Schedule GROUP BY Faculty");
            var qwery = (from A in db.Schedules orderby A.Faculty ascending select A.Faculty).Distinct().ToList();
            return JArray.FromObject(qwery);
        }

        public JArray Get(string faculty)
        {
            //List<string> facs = db.Database.ExecuteSqlCommand("SELECT Faculty FROM Schedule GROUP BY Faculty");
            var qwery = (from A in db.Schedules where A.Faculty == faculty orderby A.Faculty ascending select A.Specialty).Distinct().ToList();
            return JArray.FromObject(qwery);
        }

        public JArray Get(string faculty, string specialty)
        {
            //List<string> facs = db.Database.ExecuteSqlCommand("SELECT Faculty FROM Schedule GROUP BY Faculty");
            var qwery = (from A in db.Schedules where A.Faculty == faculty & A.Specialty == specialty orderby A.Specialty ascending select A.Section).Distinct().ToList();
            return JArray.FromObject(qwery);
        }

        public JArray Get(string faculty, string specialty, string section)
        {
            //List<string> facs = db.Database.ExecuteSqlCommand("SELECT Faculty FROM Schedule GROUP BY Faculty");
            var qwery = (from A in db.Schedules where A.Faculty == faculty & A.Specialty == specialty & A.Section == section orderby A.Term ascending select A.Term).Distinct().ToList();
            return JArray.FromObject(qwery);
        }

        // GET: api/Schedule/5
        public JObject Get(string faculty, string specialty, string section, int term)
        {
            var res = db.Schedules.FirstOrDefault((x) => x.Faculty == faculty && x.Specialty == specialty && x.Section == section && x.Term == term);
            var schedule = JObject.FromObject(res ?? new Models.Schedule());
            schedule.Remove("Id");
            return JObject.FromObject(new { status = res != null ? "ok" : "fail", schedule });
        }

        // POST: api/Schedule
        public JObject Post(Guid token, string faculty, string specialty, string section, int term,
            string monday_ch, string monday_z, string tuesday_ch, string tuesday_z,
            string wednesday_ch, string wednesday_z, string thursday_ch, string thursday_z, 
            string friday_ch, string friday_z, string saturday_ch, string saturday_z, 
            string sunday_ch, string sunday_z)
        {
            if(CurrentMemory.CurrentUsers.Find(x => x.Token == token).Token != Guid.Empty)
            {
                var res = db.Schedules.FirstOrDefault((x) => x.Faculty == faculty && x.Specialty == specialty && x.Section == section && x.Term == term);
                Models.Schedule tmp = new Models.Schedule
                {
                    Id = res == null ? Guid.NewGuid() : res.Id,
                    Faculty = faculty,
                    Specialty = specialty,
                    Section = section,
                    Term = term,
                    Monday_Ch = monday_ch,
                    Monday_Z = monday_z,
                    Tuesday_Ch = tuesday_ch,
                    Tuesday_Z = tuesday_z,
                    Wednesday_Ch = wednesday_ch,
                    Wednesday_Z = wednesday_z,
                    Thursday_Ch = thursday_ch,
                    Thursday_Z = thursday_z,
                    Friday_Ch = friday_ch,
                    Friday_Z = friday_z,
                    Saturday_Ch = saturday_ch,
                    Saturday_Z = saturday_z,
                    Sunday_Ch = sunday_ch,
                    Sunday_Z = sunday_z
                };
                db.Schedules.Add(tmp);
                db.SaveChanges();


                return JObject.FromObject(new { status = "ok" });
            }
            else
                return JObject.FromObject(new { status = "fail" });
        }
    }
}
