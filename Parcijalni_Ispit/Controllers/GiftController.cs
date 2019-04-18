using Parcijalni_Ispit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.Data.Entity;

namespace Parcijalni_Ispit.Controllers
{
    public class GiftController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Gift
        public ActionResult Index()
        {
            List<Gift> lGifts = (from g in _db.Gifts
                                 where g.Bought == false
                                 select g).ToList();
            return View(lGifts);
        }

        public ActionResult CompleteGiftList()
        {
            List<Gift> lGifts = (from g in _db.Gifts
                                 select g).ToList();
            return View(lGifts);
        }

        public ActionResult CreateGift()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGift(Gift gift)
        {
            if (ModelState.IsValid)
            {
                _db.Gifts.Add(gift);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gift);
        }

        public ActionResult EditGift(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Gift gift = _db.Gifts.Find(id);

            if (gift == null)
            {
                return HttpNotFound();
            }

            return View(gift);
        }

        [HttpPost]
        public ActionResult EditGift(Gift gift)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(gift).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gift);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Gift gift = _db.Gifts.Find(id);

            if (gift == null)
            {
                return HttpNotFound();
            }
            return View(gift);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Gift gift = _db.Gifts.Find(id);
            _db.Gifts.Remove(gift);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}