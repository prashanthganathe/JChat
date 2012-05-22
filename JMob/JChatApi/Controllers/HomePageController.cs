using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using BizService;

namespace JChatApi.Controllers
{
    public class HomePageController : ApiController
    {
        // GET /api/homepage
        public IEnumerable<Group> Get()
        {
            GroupService objGrp = new GroupService();
            return objGrp.GetGroups();
           // return new string[] { "value1", "value2" };
        }

        // GET /api/homepage/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/homepage
        public void Post(string value)
        {
        }

        // PUT /api/homepage/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/homepage/5
        public void Delete(int id)
        {
        }
    }
}
