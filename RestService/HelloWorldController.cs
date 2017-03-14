using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestService
{
    public class HelloWorldController : ApiController
    {
        public string Get()
        {
            return "Hello World from " + Environment.MachineName;
        }
    }
}
