using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01452091.Controllers
{
    public class HostingCostController : ApiController
    {
        //Bonus Question GET /api/HostingCost/{id}
        public IEnumerable<string> GET(int id)
        {
            int fn = id / 14; //Define fn

            if (id < 0) //1st Condition for fn
            {
                return new string[] { "Please try again, the number of days must be equal or greater than 0" };
            }

            if (id < 14) //2nd Condition for fn
            {
                fn = 0;
            }

            return new string[]            
            { fn + " fortnights at $5.50/FN = " + Math.Round((fn + 1) * 5.50, 2) + " CAD", //1st string: price/fortnight + deposit for the first fortnight
            "HST 13% = $" + Math.Round((fn + 1) * 5.50 * 0.13, 2) + " CAD", //2nd string: calculating HST
            "Total = $" + Math.Round((fn + 1) * 5.50 * 1.13, 2) + " CAD" }; //3rd string: total hosting cost
        }
    }
}
