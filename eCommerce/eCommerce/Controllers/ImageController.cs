﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;
using System.IO; //add system.io to let us save or get files

namespace eCommerce.Controllers
{
    [Authorize(Roles = "admin")]
    public class ImageController : BaseController
    {
    

        //
        // GET: /Image/

        public ActionResult Index()
        {
            var images = db.Images.Include(i => i.Product);
            return View(images.ToList());
        }

        //
        // GET: /Image/Details/5

        public ActionResult Details(int id = 0)
        {
            Image image = db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        //
        // GET: /Image/Create

        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name");
            return View();
        }

        //
        // POST: /Image/Create
        //add the HTTPPostedFileBase parameter to our post action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Image image, HttpPostedFileBase upload)
        {
            //handle the file upload
            //step 1: Get the filename
            string filename = upload.FileName;
            //step 2: get the file path to save the upload to
            string path = Path.Combine(Server.MapPath("~/Content/Images"), filename);
            //step 3: save our uploaded file
            upload.SaveAs(path);
            //step 4: update the image URL for our database object
            image.ImageURL= ("/Content/Images/" + filename);
            if (ModelState.IsValid)
            {
                db.Images.Add(image);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", image.ProductID);
            return View(image);
        }

        //
        // GET: /Image/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Image image = db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", image.ProductID);
            return View(image);
        }

        //
        // POST: /Image/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Image image)
        {
            if (ModelState.IsValid)
            {
                db.Entry(image).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", image.ProductID);
            return View(image);
        }

        //
        // GET: /Image/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Image image = db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        //
        // POST: /Image/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Image image = db.Images.Find(id);
            db.Images.Remove(image);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}