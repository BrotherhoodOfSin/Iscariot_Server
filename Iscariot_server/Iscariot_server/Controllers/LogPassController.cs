using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;
using Iscariot_server.DAL;
using System.Text.RegularExpressions;

namespace Iscariot_server.Controllers
{
    public class LogPassController : ApiController
    {
        //Внимание - ты сейчас немножкол удивишься
        static Iscariot_DB_Context db = new Iscariot_DB_Context();

        // GET: api/LogPass
        public JObject Get()
        {
            return JObject.FromObject(new { status = "access denied" });
        }

        // GET: api/LogPass/5
        public JObject Get(string login, string password)
        {
            /* Fetch the stored value */
            string savedPasswordHash = db.LogPasses.FirstOrDefault(u => u.Login == login).PassHash;
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    throw new UnauthorizedAccessException();
            return JObject.FromObject(new { status = "access granted" });
        }

        // POST: api/LogPass
        public JObject Post(string login, string password, string email, bool needAuth)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(email, pattern))
            {
                return JObject.FromObject(new { status = "Invalid email format" });
            }
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            db.LogPasses.Add(new Models.LogPass{ Login = login, PassHash = savedPasswordHash, Email = email, NeedAuth = needAuth });
            return JObject.FromObject(new { status = "OK" });
        }
    }
}
