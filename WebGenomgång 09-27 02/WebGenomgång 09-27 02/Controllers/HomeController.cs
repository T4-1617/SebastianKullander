using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGenomgång_09_27_02.Controllers
{
    public class HomeController : Controller
    {

        //public string Index()
        //{
        //    return "Hällo fröm wäb sörvär";
        //}
        // GET: Home
        public ActionResult Index()
        {


            //per default hamnar vi här
            //pga MS MVC conventions

            //var är våran VIEW?
            //vad heter vår VIEW?
            //per default ska den heta INDEX
            //dvs samma som denna metod heter

            return View();
        }
    }
}