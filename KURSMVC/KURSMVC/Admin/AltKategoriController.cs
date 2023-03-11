using KURSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KURSMVC.Admin
{
    public class AltKategoriController : Controller
    {
        Model1 db = new Model1();
        // GET: AltKategori
        public ActionResult Index()
        {
            var altkategoriliste = db.ALT_KATEGORI.ToList();
            if (Request["ara"] != null)
            {
                var txtAra = Request["ara"].ToString();
                altkategoriliste = db.ALT_KATEGORI.Where(e => e.ALT_KATEGORI_ADI.Contains(txtAra)).ToList();
            }
            else
            {
                altkategoriliste = db.ALT_KATEGORI.ToList();
            }
            return View(altkategoriliste);

        }
        public ActionResult Sil(int? id)
        {

            if (id != null)
            {
                var ak = db.ALT_KATEGORI.Find(id);
                if (ak != null)
                {
                    db.ALT_KATEGORI.Remove(ak);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult KayitFormu(int? id)
        {
            ALT_KATEGORI ak = new ALT_KATEGORI();
            if (id != null)
            {
                ak = db.ALT_KATEGORI.Find(id);
                if (ak == null)
                {
                    ak = new ALT_KATEGORI();
                }
            }
            var kategori = db.KATEGORI.ToList();
            ViewData["kategori"] = kategori;
            return View(ak);
        }
        [HttpPost]
        public ActionResult KayitFormu(ALT_KATEGORI ak)
        {
            if (ak.ALT_KATEGORI_REFNO == 0)
            {
                db.ALT_KATEGORI.Add(ak);
            }
            else
            {
                db.Entry(ak).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Ara(string txtAra)
        {
            return RedirectToAction("Index", new { ara = txtAra });
        }
   
    }
}