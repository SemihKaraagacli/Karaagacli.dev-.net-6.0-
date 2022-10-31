using CV.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    [Authorize]
    public class PanelProjectController : Controller
    {
        Context db = new Context();
        public IActionResult PanelProject()
        {
            var values = db.panelProjects.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult PPro_add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PPro_add(PanelProject project)
        {
            if (project.BlogDosya != null)
            {
                var extension = Path.GetExtension(project.BlogDosya.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/images/Project_images/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                project.BlogDosya.CopyTo(stream);
                project.BlogResim = newimagename;
            }
            db.panelProjects.Add(project);
            db.SaveChanges();
            return RedirectToAction("PanelProject");
        }
        [HttpGet]
        public IActionResult PPro_Get(int id)
        {
            var ppro_get = db.panelProjects.SingleOrDefault(x => x.Id == id);
            return View(ppro_get);
        }
        [HttpPost]
        public IActionResult PPro_Update(PanelProject b)
        {
            var ppro_update = db.panelProjects.SingleOrDefault(x => x.Id == b.Id);
            if (b.BlogDosya != null)
            {
                var extension = Path.GetExtension(b.BlogDosya.FileName);
                var newimagesname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/images/Project_images/", newimagesname);
                var stream = new FileStream(location, FileMode.Create);
                b.BlogDosya.CopyTo(stream);
                b.BlogResim = newimagesname;
                ppro_update.BlogResim = b.BlogResim;
            }
            ppro_update.Id = b.Id;
            ppro_update.BlogAd = b.BlogAd;
            ppro_update.BlogAdres = b.BlogAdres;
            ppro_update.BlogIcerik = b.BlogIcerik;
            db.SaveChanges();
            return RedirectToAction("PanelProject");
        }
    }
}
