using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using _2._2.Models;

namespace _2._2.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manual()
        {
            if (Request.Method == "POST")
            {
                try
                {
                    var calcModel = new CalculationModel
                    {
                        X = Int32.Parse(HttpContext.Request.Form["x"]),
                        Y = Int32.Parse(HttpContext.Request.Form["y"]),
                        Result = HttpContext.Request.Form["operation"]
                    };

                    ViewBag.Result = calcModel.toGetResult();
                }
                catch
                {
                    ViewBag.Result = "Invalid input";
                }

                return View("Result");
            }
            return View("HtmlHelperView");
        }

        [HttpGet]
        [ActionName("ManualWithSeparateHandlers")]
        public IActionResult ManualWithSeparateHandlersGet()
        {
            return View("HtmlHelperView");
        }

        [HttpPost]
        [ActionName("ManualWithSeparateHandlers")]
        public IActionResult ManualWithSeparateHandlersPost()
        {
            try
            {
                var calcModel = new CalculationModel
                {
                    X = Int32.Parse(HttpContext.Request.Form["x"]),
                    Y = Int32.Parse(HttpContext.Request.Form["y"]),
                    Result = HttpContext.Request.Form["operation"]
                   
                };

                ViewBag.Result = calcModel.toGetResult();
            }
            catch
            {
                ViewBag.Result = "Invalid input";
            }

            return View("Result");
        }

        [HttpGet]
        public IActionResult ModelBindingInParameters()
        {
            return View("HtmlHelperView");
        }

        [HttpPost]
        public IActionResult ModelBindingInParameters(int x, string operation, int y)
        {
            if (ModelState.IsValid)
            {
                var calcModel = new CalculationModel
                {
                    X = x,
                    Y = y,
                    Result = operation
                };
                ViewBag.Result = calcModel.toGetResult();
            }
            else
            {
                ViewBag.Result = "Invalid input";
            }

            return View("Result");
        }

        [HttpGet]
        public IActionResult ModelBindingInSeparateModel()
        {
            return View("TagHelperView");
        }

        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(CalculationModel model)
        {
            ViewBag.Result = ModelState.IsValid
                ? model.toGetResult()
                : "Invalid input";

            return View("Result");
        }
    }
}
