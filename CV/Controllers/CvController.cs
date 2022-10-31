using CV.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class CvController : Controller
    {
        Context db = new Context();
        public IActionResult About()
        {
            var about = db.panelAbouts.ToList();
            var profil = db.panelProfils.ToList();
            return View(Tuple.Create(about, profil));
        }
        public IActionResult Resume()
        {
            var profil = db.panelProfils.ToList();
            var education = db.panelEducations.ToList();
            var experiance = db.panelExperiances.ToList();
            return View(Tuple.Create(profil, education, experiance));
        }
        public IActionResult Project()
        {
            var profil = db.panelProfils.ToList();
            var project = db.panelProjects.ToList();
            return View(Tuple.Create(profil, project));
        }
        public IActionResult Contact()
        {
            var contact = db.panelProfils.ToList();
            return View(contact);
        }
    }
}
