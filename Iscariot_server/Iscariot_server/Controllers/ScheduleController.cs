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
        public JObject Get()
        {
            return JObject.FromObject(new { status="fail" });
        }

        // GET: api/Schedule/5
        public JObject Get(string faculty, string specialty, string section, int term)
        {
            var res = db.Schedules.FirstOrDefault((x) => x.Faculty == faculty && x.Specialty == specialty && x.Section == section && x.Term == term);
            return JObject.FromObject(new { status = res == null ? "ok" : "fail", schedule = JObject.FromObject(res) });
        }

        // POST: api/Schedule
        public void Post([FromBody]string value)
        {
        }
    }
}
