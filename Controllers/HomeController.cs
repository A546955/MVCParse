using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCParse.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public async Task<ActionResult> Index()
        {
          var testObject = new ParseObject("TestObject");
          testObject["foo"] = "fighters";
          await testObject.SaveAsync();

          return View();
        }

    }
}
