using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01452091.Controllers
{
    public class GreetingController : ApiController
    {
        //Question 3 POST /api/Greeting
        public string POST()
        {
            return "Hello World!";
        }

        //Question 4 GET /api/Greeting/{id}
        public string GET(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
