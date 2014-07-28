using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers{
    [Authorize(Roles = "admin")]
    public class SupplierController : BaseController
    {   //make a connection to the database
       //its made in the base controller
        //
        // GET: /Supplier/

        public ActionResult Index()
        {
            return View(db.Suppliers);
        }//index will return all the suppliers
    [HttpGet]//get post create
        public ActionResult Create()
        {//pass the blank supplier object to the view
            return View(new Models.Supplier());
        }
    //Suppliers: /Supplier/Create
    [HttpPost]
    public ActionResult Create(Models.Supplier supplier)
    {
        db.Suppliers.Add(supplier);
        db.SaveChanges();
        return RedirectToAction("Index", "Supplier");
    }
    [HttpGet]
    public ActionResult Delete(int id)
    {
        Models.Supplier supplierToDelete = db.Suppliers.Find(id);
        return View(supplierToDelete);
    }
    //Supplier: supplier/delete/{id}
    //using actionname "Delete" so the URL stays the same, but the function can have a different name
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        //get the supplier from the database
        Models.Supplier supplierToDelete = db.Suppliers.Find(id);
        db.Suppliers.Remove(supplierToDelete);
        db.SaveChanges();//save changes or nothing will happen
        return RedirectToAction("Index", "Supplier");
    }
    //get supplier/edit/id
    [HttpGet]
    public ActionResult Edit(int id)
    {
        Models.Supplier supplierToEdit = db.Suppliers.Find(id);
        //pass our supplier to edit to View
        return View(supplierToEdit);
    }
    [HttpPost]
    public ActionResult Edit(Models.Supplier supplierToEdit)
    {
        //set the supplier to be updated
        db.Entry(supplierToEdit).State = System.Data.EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index", "Supplier");
    }
    public ActionResult Details(int id)
    {
        //get the supplier from the database
        Models.Supplier detail = db.Suppliers.Find(id);
        return View(detail);
    }
}



}
