using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01452091.Controllers
{    
    public class AddTenController : ApiController
    {
        //Question 1 GET /api/AddTen/{id}
        public int GET(int id)
        {
            return id + 10;
        }
    }
}
