using MVC_Webapp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Webapp.Controllers
{
    public class UsersController : Controller
    {
        ServicesContext db = new ServicesContext();
        // GET: Users
        public ActionResult Index()
        {
            var data = db.user.ToList();
            return View(data);
        }
        
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(UsersModel e)
        {
            if(ModelState.IsValid == true)
            {

                db.user.Add(e);
               int a = db.SaveChanges();
                if(a > 0)
                {
                    ViewBag.CreateMessage = ("<script>alert('Data Saved..')</script>");
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.CreateMessage = ("<script>alert('Data Not Saved..')</script>");


                }
            }

            return View(e);
        }

        public ActionResult Edit(int id)
        {

            var row = db.user.Where(user => user.UserId == id).FirstOrDefault();
          
            return View(row);

        }

        [HttpPost]
        public ActionResult Edit(UsersModel user) {

            db.Entry(user).State = EntityState.Modified;
            
            int a = db.SaveChanges();
            if (a > 0)
            {
                //ViewBag.UpdateMessage = ("<script>alert('Data Saved..')</script>");
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.UpdateMessage = ("<script>alert('Data Not Modified..')</script>");


            }
            return View();
         }


      

        public ActionResult Delete(int id)
        {
            var row = db.user.Where(user => user.UserId == id).FirstOrDefault();
            db.user.Remove(row);
            int a = db.SaveChanges();

            if (a > 0)
            {
                ViewBag.DeletedMessage = ("<script>alert('Data Deleted..')</script>");
                //ModelState.Clear();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.DeletedMessage = ("<script>alert('Data Not Deleted..')</script>");


            }
            return View();

        }

       

        
    }
}
