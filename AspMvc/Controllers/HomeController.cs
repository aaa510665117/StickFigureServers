using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace AspMvc.Controllers
{
    class Student
    {
        public int id { get; set; }
        public String name { get; set; }
    }

    class Employee
    {
        public int e_id { get; set; }
        public String e_name { get; set; }
    }

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            int[] table = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var buildName = new List<Object>();
            var lineChart = new List<Object>();
            var data = new List<Object>();

            //向buildName中添加数组0，数组0内的元素为number类型
            var p = from p1 in table
                    where p1 % 2 == 0
                    select p1;
            buildName.Add(p);

            //向buildName中添加数组1，数组1内的元素为Object类型
            var q = from q1 in table
                    where q1 % 3 == 0
                    select new { id = q1 };
            buildName.Add(q);

            //向buildName中添加对象，对象的内同为数组1
            buildName.Add(new { id = q });

            data.Add(new
            {
                Buildname = buildName,
                Linechart = lineChart
            });
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
