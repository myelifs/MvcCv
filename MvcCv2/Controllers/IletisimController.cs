using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv2.Models.Entity;
using MvcCv2.Repositories;

namespace MvcCv2.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Tbliletisim> repo = new GenericRepository<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.Lİst();
            return View(mesajlar);
        }
    }
}