using CV.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    [Authorize]
    public class PanelExperianceController : Controller
    {
        Context db = new Context();
        public IActionResult PanelExperiance()
        {
            var values = db.panelExperiances.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult PE_Add()
        {
            return View();

        }
        [HttpPost]
        public IActionResult PE_Add(PanelExperiance p)
        {
            db.panelExperiances.Add(p);
            db.SaveChanges();
            return RedirectToAction("PanelExperiance");
        }
        [HttpGet]
        public IActionResult PE_Get(int Id)
        {
            var get = db.panelExperiances.SingleOrDefault(x => x.Id == Id);
            return View(get);
        }
        [HttpPost]
        public IActionResult PE_Update(PanelExperiance e)
        {
            var update = db.panelExperiances.SingleOrDefault(x => x.Id == e.Id);
            update.Id = e.Id;
            update.DeneyimAd = e.DeneyimAd;
            update.DeneyimAlan = e.DeneyimAlan;
            update.DeneyimYıl = e.DeneyimYıl;
            update.DeneyimIcerik = e.DeneyimIcerik;
            db.SaveChanges();
            return RedirectToAction("PanelExperiance");
        }
    }
}
