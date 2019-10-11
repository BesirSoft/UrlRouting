using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlRouting.Models;

namespace UrlRouting.Controllers
{


    [Route("api/[action]/{id?}")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView", new Result()
            {

                Controller = "HomeController",
                Action = "Index"

            });
        }





        public IActionResult List()
        {
            return View("MyView", new Result()
            {

                Controller = "ProductController",
                Action = "List"

            });
        }



        public IActionResult Newest()
        {
            return View("MyView", new Result()
            {

                Controller = "ProductController",
                Action = "Newest"

            });
        }


        public IActionResult Details()
        {
            //rou data alma yontemi2
          var rout= RouteData.Values["id"]; ;
            var result= new Result()
            {

                Controller = "ProductController",
                Action = "DetaiLs"

            };
            result.RoutData["Id"] = rout;
          
            return View("MyView", result);

        }

    }
}