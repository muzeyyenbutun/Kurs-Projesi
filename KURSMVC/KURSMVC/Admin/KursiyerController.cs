using KURSMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace KURSMVC.Admin
{
    public class KursiyerController : Controller
    {
        Model1 db = new Model1();
        // GET: Kursiyer
        public ActionResult Index()
        {
            var kursiyer = db.KURSIYER.ToList();
            return View(kursiyer);
        }
        public ActionResult Sil(int id)
        {
            var k = db.KURSIYER.Find(id);
            db.KURSIYER.Remove(k);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KayitFormu(int? id)
        {
            KURSIYER k = new KURSIYER();
            if (id!=null)
            {
                k = db.KURSIYER.Find(id);
                if (k==null)
                {
                    k = new KURSIYER();
                }
            }
            var ogrenım_adı = db.OGRENIM.ToList();
            ViewData["ogrenım_adı"] = ogrenım_adı;
            return View(k);
        }
        [HttpPost]
        public ActionResult KayitFormu(KURSIYER kursiyer)
        {
            if (kursiyer.KURSIYER_REFNO==0)
            {
                db.KURSIYER.Add(kursiyer);
            }
            else
            {
                db.Entry(kursiyer).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");  
        }
        public ActionResult Ara(string txtAra)
        {
            return RedirectToAction("Index",new { ara=txtAra});
        }
    }
}