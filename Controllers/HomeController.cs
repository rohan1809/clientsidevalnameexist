using IsNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IsNew.Controllers
{
    public class HomeController : Controller
    {
        ISnewKMEntities db = new ISnewKMEntities();
        public ActionResult Index()
        {
            var ISnew = db.tbl_IsNew.ToList();
            return View(ISnew);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            var model = new tbl_IsNew
            {
                IsNew = true
            };
            return View(model);
           
        }
        [HttpPost]
        public ActionResult Create(tbl_IsNew model)
        {
            if (ModelState.IsValid)
            {
                
                var isnew = new tbl_IsNew();
                isnew.IsNew = model.IsNew;
                isnew.Kms = model.Kms;
                isnew.Name = model.Name;
                db.tbl_IsNew.Add(isnew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View();
          
        }
        [HttpPost]
        public JsonResult CheckName(string name)
        {
            bool result = !db.tbl_IsNew.ToList().Exists(model => model.Name == name);/*.Equals(name, StringComparison.CurrentCultureIgnoreCase)*/
            return Json(result);
        }
    }
}