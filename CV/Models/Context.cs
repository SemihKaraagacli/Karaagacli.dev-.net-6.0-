using Microsoft.EntityFrameworkCore;

namespace CV.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7OMS01D; database=CV_DB; integrated security=true; Trust Server Certificate=true;");
        }

        public DbSet<PanelProfil> panelProfils { get; set; }
        public DbSet<PanelAbout> panelAbouts { get; set; }
        public DbSet<PanelEducation> panelEducations { get; set; }
        public DbSet<PanelExperiance> panelExperiances { get; set; }
        public DbSet<PanelProject> panelProjects { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
