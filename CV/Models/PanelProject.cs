using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class PanelProject
    {
        [Key]
        public int Id { get; set; }
        public string? BlogAd { get; set; }
        public string? BlogIcerik { get; set; }
        public string? BlogResim { get; set; }
        public string? BlogAdres { get; set; }

        [NotMapped]
        public IFormFile BlogDosya { get; set; }
    }
}
