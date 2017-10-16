using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Configuration;
using MvcApplication1.Models;
using MvcApplication1.Service;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(HotelSearch hotelSearch)
        {
            if (Request.HttpMethod == "GET")    // page requested
            {
                return View((IList<HotelOffer>)null);
            }
            ViewBag.HotelSearch = hotelSearch;
            IList<HotelOffer> hotelOffers = HotelService.GetOffers(hotelSearch);
            if (hotelOffers == null)
                return View(new List<HotelOffer>());
            return View(hotelOffers);
        }
    }
}
