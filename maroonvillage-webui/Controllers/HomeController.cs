using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using maroonvillage.webui.Models;
using System.Text;
using maroonvillage.webui.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Html;

namespace maroonvillage.webui.Controllers
{
    public class HomeController : ControllerBase
    {

        private readonly IDomainService _domainService;
        private readonly IConfiguration _configuration;

        public HomeController(IDomainService domainService, IConfiguration configuration)
        {
            _configuration = configuration;
            _domainService = domainService;
        }


        public IActionResult Index()
        {
            //var valueToStoreInRedis = Encoding.UTF8.GetBytes("This is a cached value from Redis");
            //HttpContext.Session.Set("TestProperty", valueToStoreInRedis)
            //var valueFromRedis = default(byte[]);
            //if (HttpContext.Session.TryGetValue("TestProperty", out valueFromRedis))
            //    valueToDisplay = Encoding.UTF8.GetString(valueFromRedis)
            var model = CreateModel<HomeModel>(action: x =>

             x.PageTitle = "Home Page"
         );

            var carouselCount = _configuration.GetValue<string>("CarouselCount") ??
                (!string.IsNullOrEmpty(_configuration.GetValue<string>("CarouselCount")) ? _configuration.GetValue<string>("CarouselCount") : "-1");

            var cities = _domainService.GetCities(Convert.ToInt32(carouselCount));

            model.Carousel = cities ?? new List<CityModel>();
           
            return View(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
