using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Newtonsoft.Json.Linq;

namespace AspMvc.Controllers
{
    public class GetPhotoLinkController : Controller
    {
        public class strAry1
        {
            public List<string> animal { get; set; }
        }
        public class strAry2
        {
            public List<string> fruits { get; set; }
        }
        public class strAry3
        {
            public List<string> vegetables { get; set; }
        }
        public class strAry4
        {
            public List<string> cartoon { get; set; }
        }
        public class strAry5
        {
            public List<string> Vehicle { get; set; }
        }
        public ActionResult Index()
        {
            strAry1 strAry1 = new strAry1();
            strAry1.animal = new List<string>();
            for (int a = 1; a < 22; a++){
                string str = "https://stickfigure-1-1253886669.cos.ap-beijing.myqcloud.com/StickFigure/Animal/"+ a +"/" + a + "-1.jpg";
                strAry1.animal.Add(str);
            }
            strAry2 strAry2 = new strAry2();
            strAry2.fruits = new List<string>();
            for (int a = 1; a < 16; a++)
            {
                string str = "https://stickfigure-1-1253886669.cos.ap-beijing.myqcloud.com/StickFigure/Fruits/" + a + "/" + a + "-1.jpg";
                strAry2.fruits.Add(str);
            }
            strAry3 strAry3 = new strAry3();
            strAry3.vegetables = new List<string>();
            for (int a = 1; a < 14; a++)
            {
                string str = "https://stickfigure-1-1253886669.cos.ap-beijing.myqcloud.com/StickFigure/Vegetables/" + a + "/" + a + "-1.jpg";
                strAry3.vegetables.Add(str);
            }
            strAry4 strAry4 = new strAry4();
            strAry4.cartoon = new List<string>();
            for (int a = 1; a < 16; a++)
            {
                string str = "https://stickfigure-1-1253886669.cos.ap-beijing.myqcloud.com/StickFigure/Cartoon/" + a + "/" + a + "-1.jpg";
                strAry4.cartoon.Add(str);
            }
            strAry5 strAry5 = new strAry5();
            strAry5.Vehicle = new List<string>();
            for (int a = 1; a < 16; a++)
            {
                string str = "https://stickfigure-1-1253886669.cos.ap-beijing.myqcloud.com/StickFigure/Vehicle/" + a + "/" + a + "-1.jpg";
                strAry5.Vehicle.Add(str);
            }
            var data = new List<Object>();
            data.Add(strAry1);
            data.Add(strAry2);
            data.Add(strAry3);
            data.Add(strAry4);
            data.Add(strAry5);
            return Json(data, JsonRequestBehavior.AllowGet);

            //var obj = new JObject();
            //obj.Add(data);
            //JObject outObject = new JObject();
            // outObject.Add("result", obj);
        }
    }
}
