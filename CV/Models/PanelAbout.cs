using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class PanelAbout
    {
        [Key]
        public int Id { get; set; }
        public string? Tanıtım { get; set; }
        public string? NelerYapıyorumAd { get; set; }
        public string? NelerYapıyorumIcerik { get; set; }
    }
}
