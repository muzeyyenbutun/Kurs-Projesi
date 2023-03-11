using KURSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace KURSMVC.Admin
{
    public class EgitimController : Controller
    {
        Model1 db = new Model1();
        // GET: Egitim
        public ActionResult Index()
        {
            var liste=new List<EGITIM>();
            if (Request["ara"]!=null)
            {
                var txtAra = Request["ara"].ToString();
                liste = db.EGITIM.Where(e=>e.EGITIM_ADI.Contains(txtAra)).ToList();
            }
            else
            {
                liste=db.EGITIM.ToList();
            }
            return View(liste);
        }
        public ActionResult Sil(int? id)
        {

            if (id!= null)
            {
                var egitim = db.EGITIM.Find(id);
                if (egitim != null) 
                { 
                db.EGITIM.Remove(egitim);
                db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        //Yeni,Düzenle
        public ActionResult KayitFormu(int? id)
        {
            EGITIM egitim = new EGITIM();
            if (id!=null)
            {
                egitim = db.EGITIM.Find(id);
                if (egitim==null)
                {
                    egitim = new EGITIM();
                }
            }
            var kategori = db.KATEGORI.ToList();
            ViewData["kategori"] = kategori;
            return View(egitim);
        }
        [HttpPost]
        public ActionResult KayitFormu(EGITIM egitim)
        {
            if (egitim.EGITIM_REFNO==0)
            {
                db.EGITIM.Add(egitim);
            }
            else
            {
                db.Entry(egitim).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Ara(string txtAra)
        {
            return RedirectToAction("Index",new {ara=txtAra});
        }
        public JsonResult AltKategori(int kategorirefno)
        {
            var altkategori = db.ALT_KATEGORI.Where(k=>k.KATEGORI_REFNO==kategorirefno).ToList();
            return Json(altkategori,JsonRequestBehavior.AllowGet);
        }
    }
}