using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using BizService;
using Newtonsoft.Json;
using System.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
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

        // GET /api/homepage/GetUserName
        //public string GetUserName()
        //{
        //    User usrObj = new User();
        //    usrObj.IP = System.Web.HttpContext.Current.Request.UserHostAddress;
        //    UserService userSerObj = new UserService();
        //    return userSerObj.Create(usrObj);
        //}


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
