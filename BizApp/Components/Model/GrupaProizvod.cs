using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{

    [Table("GrupaProizvoda", Schema = "dbo")]
    public class GrupaProizvod
    {
        public int ID { get; set; }
        [MaxLength(50, ErrorMessage = "predugacko"), MinLength(2, ErrorMessage = "prektatko")]
        public string Naziv { get; set; }
        public int? Sortiranje { get; set; }

        public ICollection<Proizvod> Proizvodi { get; set; }
    }
}
