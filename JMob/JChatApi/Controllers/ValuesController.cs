using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using BizService;

namespace JChatApi.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET /api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        // GET /api/values
        public MyDataClass Get()
        {
            return new MyDataClass
            {
                MyProperty1 = "Property 1", // String
                MyProperty2 = true, // Bool
                MyProperty3 = 987654, // Integer
                MyProperty4 = 100.87m // Decimal
            };
        }

        // GET /api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/values
        public void Post(string value)
        {
        }

        // PUT /api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/values/5
        public void Delete(int id)
        {
        }
    }
}