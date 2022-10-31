using CV.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    [Authorize]
    public class PanelEducationController : Controller
    {
        Context db = new Context();
        public IActionResult PanelEducation()
        {
            var deger = db.panelEducations.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult PE_Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PE_Add(PanelEducation education)
        {
            db.panelEducations.Add(education);
            db.SaveChanges();
            return RedirectToAction("PanelEducation");
        }
        [HttpGet]
        public IActionResult PE_Get(int Id)
        {
            var pe_get = db.panelEducations.SingleOrDefault(x => x.Id == Id);
            return View(pe_get);
        }
        [HttpPost]
        public IActionResult PE_Update(PanelEducation education)
        {
            var pe_update = db.panelEducations.SingleOrDefault(x => x.Id == education.Id);
            pe_update.Id = education.Id;
            pe_update.OkulAd = education.OkulAd;
            pe_update.OkulYıl = education.OkulYıl;
            pe_update.OkulAlan = education.OkulAlan;
            pe_update.OkulIcerik = education.OkulIcerik;
            db.SaveChanges();
            return RedirectToAction("PanelEducation");
        }
    }
}
