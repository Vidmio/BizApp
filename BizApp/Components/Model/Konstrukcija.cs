using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BizApp.Components.Model
{
    [Table("Konstrukcije", Schema = "dbo")]
    public class Konstrukcija
    {
        public int ID { get; set; }
        [MaxLength(50, ErrorMessage = "to long")]
        public string? Naziv { get; set; }
        [MaxLength(110, ErrorMessage = "to long")]
        public string? Opis { get; set; }
        [MaxLength(110, ErrorMessage = "to long")]

        public int? Profil120x60 { get; set; }
        public int? Profil40x80 { get; set; }
        public int? PZida { get; set; }
        public int? PPoda { get; set; }
        public int? PKrova { get; set; }

        public ICollection<FakturaKonstrukcija> FakturaKonstrikcija { get; set; }
    }
}
