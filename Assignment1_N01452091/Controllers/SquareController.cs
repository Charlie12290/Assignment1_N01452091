using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01452091.Controllers
{
    public class SquareController : ApiController
    {
        //Question 2 GET /api/Square/{id}
        public int GET(int id)
        {
            return id * id;
        }
    }
}
