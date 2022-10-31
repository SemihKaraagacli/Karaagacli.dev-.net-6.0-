using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
    }
}
