using dbfirstcoreproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace dbfirstcoreproject.Controllers
{
    public class AgalerisiController : Controller
    {
        public readonly GaleriCoreDbContext Context;
        public AgalerisiController(GaleriCoreDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index()
        {
            return View(Context.Agalerisis.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Agalerisi agalerisi)
        {
            Context.Add(agalerisi);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(Context.Agalerisis.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Agalerisi agalerisi)
        {
            Context.Update(agalerisi);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
           var soru=Context.Agalerisis.Find(id);
            return View(soru);
        }
        [HttpPost]
        public IActionResult Delete(int id,Agalerisi agalerisi)
        {
            Context.Remove(Context.Agalerisis.Find(id));
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
