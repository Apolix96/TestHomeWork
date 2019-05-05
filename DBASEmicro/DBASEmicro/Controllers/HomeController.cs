using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBASEmicro.Models;
using DBASEmicro.Solid;
namespace DBASEmicro.Controllers
{
    public class HomeController : Controller
    {
        CreateSet CreSet = new CreateSet();
        FindSet findSet = new FindSet();
        EditSet editSet = new EditSet();
        DeleteSet deleteSet = new DeleteSet();
        ExtractSet extractSet = new ExtractSet();
       

        ContextMicro ConM = new ContextMicro();
       
        public ActionResult Index()
        {
            ViewBag.MicCon = extractSet.DataUse();
            return View();
        }
        // информация
        [HttpGet]
        public ActionResult Infor(int? id)
        {
            MicroController b = ConM.MicCon.Find(id);
            return View(b);
        }
        // купить
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.IDmicro = Convert.ToInt32(id);
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.date = DateTime.Now;

            ConM.PurshSE.Add(purchase);
            ConM.SaveChanges();
            return "Cпасибо, " + purchase.namePurchase + ", за покупку!" + "дата покупки" + purchase.date;
        }
        //создать
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MicroController microController)
        {
            CreSet.CSete(microController);
            return RedirectToAction("Index");
            
        }
        [HttpGet]
        //изменить
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            MicroController microController = ConM.MicCon.Find(id);

            if (microController != null)
            {
                return View(microController);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(MicroController microController)
        {
           
            editSet.Edit(microController);
          return RedirectToAction("Index");
        }
        
        // удалить
        [HttpGet]
        public ActionResult Delete(int id)
        {
            MicroController b = ConM.MicCon.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MicroController b = ConM.MicCon.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            ConM.MicCon.Remove(b);
            ConM.SaveChanges();
            return RedirectToAction("Index");
        }


        //auto появление
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}
