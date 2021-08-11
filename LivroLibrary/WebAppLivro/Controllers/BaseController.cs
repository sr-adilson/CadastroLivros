using LivroLibrary.Models;
using LivroLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppLivro.Controllers
{
    public class BaseController<M, R> : Controller where M: LivroBaseModel where R: LivroBaseRepository<M>

    {
        R repo = Activator.CreateInstance<R>();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(M model)
        {
            repo.Create(model);
            return RedirectToAction("list");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repo.Read(id));
        }
        [HttpPost]
        public ActionResult Edit(M model)
        {
            repo.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            return View(repo.Read());
        }
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("List");
        }
    }
}