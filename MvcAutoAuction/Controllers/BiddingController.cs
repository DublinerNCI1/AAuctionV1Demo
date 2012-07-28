using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAutoAuction.Models;
using System.Data.Entity;
using System.Data;

namespace MvcAutoAuction.Controllers
{
    [Authorize]
    public class BidController : Controller
    {
        AutoAuctionEntities catalogDB = new AutoAuctionEntities();
        // const string SecurityPass = "Willcontactifbidsuccessful";

        //
        // GET: /Bid/Bidding Form

        public ActionResult BiddingForm()
        {
          //  int x = carid;
          //  ViewData ["x"] = (x);
            return View();
        }

        [HttpPost]
        public ActionResult BiddingForm(Bid bid)
        {
            // bid.Car.CarId = new Bid.car.carId  
            catalogDB.Bids.Add(bid);
            catalogDB.SaveChanges();
            return View("BiddingSummary");
        }

        public ActionResult BiddingSummary(Bid bid)
        {
            return View("BiddingSummary", bid);
        }

        public ActionResult BiddingHistory()
        {

            var bids = catalogDB.Bids.Include(c => c.Car);
            var listbids = bids.ToList();
            return View (listbids);
            // return View("BiddingHistory");
        }
    }
}


