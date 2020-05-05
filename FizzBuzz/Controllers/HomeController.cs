using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {

            int pagesize = 20;
            int pageNumber = (page ?? 1);
            //List<int> iPageNumber = new List<int> { 1,2,3,4,5};
            
            List<string> iData = new List<string>();
            //foreach (int count in iPageNumber)
            //{
                int j = 1;
                while (j <= 100)
                {
                    if (j % 15 == 0)
                    {
                        iData.Add("Fiz Buzz");
                    }
                    else
                    {
                        if (j % 5 == 0)
                        {
                            iData.Add("Buzz");
                        }
                        else
                        {
                            if (j % 3 == 0)
                            {
                                iData.Add("Fiz");
                            }
                            else
                            {
                                iData.Add(j.ToString());
                            }
                        }

                    }
                    j++;
                }
            //}
           //ViewBag.Index = iData.ToPagedList(pageNumber, pagesize);
           
            return View(iData.ToPagedList(pageNumber, pagesize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}