using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iformcollection.Controllers
{
    public class IformcollectionConController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult add(IFormCollection obj)
        {
            for (var x= 0; x<obj.Keys.Count-1;x++)
            {
                string str = obj["txt1"][x].ToString();
            }
            

            return View();
        }
    }
}
