using Aula.Exemplo.BO;
using Aula.Exemplo.VO;
using Aula.Exempo.SiteMVC.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula.Exempo.SiteMVC.Controllers
{
    public class alunoController : Controller
    {
        private alunoBO alunoBO = new alunoBO(SecurityHelper.GetObjectSecurity());
        private SelectListHelper selectHelper = new SelectListHelper();


        // GET: aluno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.idEstadoCivilList = selectHelper.GetEstadoCivilList("");
            return View();

        }

        [HttpPost]
        public ActionResult Create(aluno a)
        {
            alunoBO.Insert(a);
            return RedirectToAction("Index");
        }

    }
}