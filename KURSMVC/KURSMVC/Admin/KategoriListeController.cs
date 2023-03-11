using KURSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KURSMVC.Admin
{
    public class KategoriListeController : Controller
    {
        Model1 db = new Model1();
        // GET: KategoriListe
        public ActionResult Index()
        {
            var liste = db.KATEGORI.ToList();
            if (Request["ara"] != null)
            {
                var txtAra = Request["ara"];
                liste = db.KATEGORI.Where(k=>k.KATEGORI_ADI.Contains(txtAra)).ToList();
            }
            return View(liste);
        }
        public ActionResult Sil(int id)
        {
            var k=db.KATEGORI.Find(id);
            db.KATEGORI.Remove(k);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //KayitFormu 2 şekilde gelebilir.
        // KayitFormu/4 veya KayitFormu şeklinde
        [HttpGet]
        public ActionResult KayitFormu(int? id)
        {
            KATEGORI k = new KATEGORI();
            if (id!=null)
            {
                k = db.KATEGORI.Find(id);
                if (k==null)
                {
                    k = new KATEGORI();
                }
            }
            return View(k);
        }
        [HttpPost]
        public ActionResult KayitFormu(KATEGORI k)
        {
            if (k.KATEGORI_REFNO==0)//yeni
            {
                db.KATEGORI.Add(k);
            }
            else//eski
            {
                db.Entry(k).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Ara(string txtAra)
        {
            return RedirectToAction("Index","KategoriListe",new {ara=txtAra});//?ara=s gibi mesela
        }
    }
}