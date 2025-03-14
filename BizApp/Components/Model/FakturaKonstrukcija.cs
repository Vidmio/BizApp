using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{

    [Table("FakturaKonstrikcije", Schema = "dbo")]
    public class FakturaKonstrukcija
    {
        public int ID { get; set; }
        public int KonstrikcijaID { get; set; }
        [ForeignKey("KonstrikcijaID")]
        public Konstrukcija Konstrukcija { get; set; }
        public int FakturaID { get; set; }
        [ForeignKey("FakturaID")]
        public Faktura Faktura { get; set; }
        public ICollection<Stavka> Stavka { get; set; }
    }
}
