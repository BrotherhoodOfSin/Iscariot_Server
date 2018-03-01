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

        }
    }
}