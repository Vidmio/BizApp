using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{
    [Table("Klijenti", Schema = "dbo")]
    public class Klijent
    {
        public int ID { get; set; }
        [MaxLength(50, ErrorMessage = "predugacko"), MinLength(2, ErrorMessage = "prektatko")]
        public string Naziv { get; set; }
        public int? PIB { get; set; }
        public int? MaticniBR { get; set; }
        [MaxLength(50, ErrorMessage = "predugacko"), MinLength(2, ErrorMessage = "prektatko")]
        public string? Ime { get; set; }
        [MaxLength(50, ErrorMessage = "predugacko"), MinLength(2, ErrorMessage = "prektatko")]
        public string? Prezime { get; set; }
        public int? Telefon1 { get; set; }
        public int? Telefon2 { get; set; }
        public string? Napomena { get; set; }

        public ICollection<Faktura> Fakture { get; set; }





    }
}
