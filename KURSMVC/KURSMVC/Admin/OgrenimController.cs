using KURSMVC.Models;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KURSMVC.Admin
{
    public class OgrenimController : Controller
    {
        // GET: Ogrenim
        Model1 db = new Model1();
        public ActionResult Index()
        {
            var liste = db.OGRENIM.ToList();
            if (Request["ara"]!=null)
            {
                var txtAra = Request["ara"];
                liste = db.OGRENIM.Where(m=>m.OGRENIM_ADI.Contains(txtAra)).ToList();
            }
            return View(liste);
        }
        public ActionResult Sil(int id)
        {
            var o = db.OGRENIM.Find(id);
            db.OGRENIM.Remove(o);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KayitFormu(int? id)
        {
            OGRENIM o = new OGRENIM();
            if (id != null)
            {
                o = db.OGRENIM.Find(id);
                if (o == null)
                {
                    o = new OGRENIM();
                }
            }
            return View(o);
        }
        [HttpPost]
        public ActionResult KayitFormu(OGRENIM o)
        {
            if (o.OGRENIM_REFNO == 0)//yeni
            {
                db.OGRENIM.Add(o);
            }
            else//eski
            {
                db.Entry(o).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Ara(string txtAra)
        {
            return RedirectToAction("Index", "Ogrenim", new { ara = txtAra });//?ara=s gibi mesela
        }
    }

}