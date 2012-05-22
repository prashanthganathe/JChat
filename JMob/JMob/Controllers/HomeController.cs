using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JChatApi;
using Newtonsoft.Json;
using System.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;



namespace JMob.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            //User usrObj = new User();
            //usrObj.IP = System.Web.HttpContext.Current.Request.UserHostAddress;
            //UserService userSerObj = new UserService();
            //string username = userSerObj.Create(usrObj);
            //GetUserName();

           //WORKING

            using (WebClient proxy = new WebClient())
            {
                proxy.Headers.Add(HttpRequestHeader.Accept, "application/json");
                var response = proxy.DownloadString("http://localhost:9000/api/HomePage");
                string json = JsonConvert.SerializeObject(response);
              //  Product deserializedProduct = JsonConvert.DeserializeObject<Product>(json);
                ViewData["Grp"] = response;
                return View();
            }

           
         
           
        }




        //private object Get(string uri)
        //{
           
        //    bool isSuccess = true;
        //    HttpClient client=new HttpClient();
        //    client.GetAsync(uri)
        //                    .ContinueWith(task =>
        //                    {   
        //                        // EnsureStatus
        //                        isSuccess = task.Result.IsSuccessStatusCode;
        //                        task
        //                        .Result
        //                        .Content
        //                        .ReadAsAsync<JsonArray>()
        //                        .ContinueWith((t) => 
                                    
        //                           foreach(var w in task.)
        //                                {
        //                                    object obj = w;
        //                                }                                
                                    
        //                            )
        //                        .Wait();
        //                    })
        //                    .Wait();
        //    return result;
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
