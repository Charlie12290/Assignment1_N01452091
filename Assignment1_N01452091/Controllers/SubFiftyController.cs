using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01452091.Controllers
{
    public class SubFiftyController : ApiController
    {
        //GET /api/SubFifty/40 -> -10
        public int Get(int id) 
        {

            return (id - 50);
        }
    }
}
