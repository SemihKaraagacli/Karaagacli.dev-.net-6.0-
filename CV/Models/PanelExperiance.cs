using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class PanelExperiance
    {
        [Key]
        public int Id { get; set; }
        public string? DeneyimAd { get; set; }
        public string? DeneyimYıl { get; set; }
        public string? DeneyimAlan { get; set; }
        public string? DeneyimIcerik { get; set; }
    }
}
