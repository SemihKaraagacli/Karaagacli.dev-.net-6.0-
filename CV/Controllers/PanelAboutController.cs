using CV.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    [Authorize]
    public class PanelAboutController : Controller
    {
        Context db = new Context();
        public IActionResult PanelAbout()
        {
            var values = db.panelAbouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult PA_Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PA_Add(PanelAbout p)
        {
            db.panelAbouts.Add(p);
            db.SaveChanges();
            return RedirectToAction("PanelAbout");
        }
        public IActionResult PA_Get(int Id)
        {
            var pa_get = db.panelAbouts.Find(Id);
            return View("PA_Get", pa_get);
        }
        public IActionResult PA_Update(PanelAbout h)
        {
            var pa_update = db.panelAbouts.Find(h.Id);
            pa_update.Tanıtım = h.Tanıtım;
            pa_update.NelerYapıyorumAd = h.NelerYapıyorumAd;
            pa_update.NelerYapıyorumIcerik = h.NelerYapıyorumIcerik;
            db.SaveChanges();
            return RedirectToAction("PanelAbout");
        }
    }
}
