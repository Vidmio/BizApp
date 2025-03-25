using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{
    [Table("Lageri", Schema = "dbo")]
    public class Lager
    {
        public int ID { get; set; }
        public int Kolicina { get; set; }
        public int ProizvodID { get; set; }
        [ForeignKey("ProizvodID")]
        public Proizvod Proizvod { get; set; }

    }
}
