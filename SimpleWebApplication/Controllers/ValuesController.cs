using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using RingCentral;

namespace SimpleWebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<IEnumerable<string>> Get()
        {
            var rc = new RestClient("", "", "https://platform.devtest.ringcentral.com");
            await rc.Authorize("", "", "");
            var extInfo = await rc.Restapi().Account().Extension().Get();
            return new string[] { "value1", "value2", extInfo.extensionNumber };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
