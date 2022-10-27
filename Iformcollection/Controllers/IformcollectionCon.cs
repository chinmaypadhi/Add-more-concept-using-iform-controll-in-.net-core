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
        public class propData
        {
            public int studentId { get; set; }
            public string studentName { get; set; }
            public string studentCity { get; set; }
            public string SinglestudentId { get; set; }
            public string SinglestudentName { get; set; }
            public string SinglestudentCity { get; set; }           
        }
        public IActionResult add(propData propobj,IFormCollection obj)
        {
            List<propData> objList = new List<propData>();
            string[] id = obj["id"].ToString().Split(char.Parse(","));
            string[] name = obj["name"].ToString().Split(char.Parse(","));
            string[] city = obj["city"].ToString().Split(char.Parse(","));

            for (var x= 0; x< id.Length; x++)
            {
                propData objProp = new propData() {studentId=Convert.ToInt32(id[x]),studentName= name[x].ToString(),studentCity= city[x].ToString() };               
                objList.Add(objProp);
            }
            

            return View();
        }
    }
}
