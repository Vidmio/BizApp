using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{
    [Table("Proizvodi", Schema = "dbo")]
    public class Proizvod
    {
        public int ID { get; set; }
        [MaxLength(50, ErrorMessage = "to long"), MinLength(2, ErrorMessage = "to short")]
        public string? Naziv { get; set; }
        [MaxLength(50, ErrorMessage = "to long"), MinLength(2, ErrorMessage = "to short")]
        public string? Opis { get; set; }
        [MaxLength(50, ErrorMessage = "to long"), MinLength(2, ErrorMessage = "to short")]
        public string? Jedinica { get; set; }
        public int? Kolicina { get; set; }
        public int? JedinicnaCena { get; set; }
        public int GrupaProizvodID { get; set; }
        [ForeignKey("GrupaProizvodID")]
        public GrupaProizvod GrupaProizvod { get; set; }

        public ICollection<Stavka> Stavka { get; set; }
    }
}
