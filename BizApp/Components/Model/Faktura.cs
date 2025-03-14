using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{
    [Table("Fakture", Schema = "dbo")]
    public class Faktura
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public int KlijentID { get; set; }
        [ForeignKey("KlijentID")]
        public  Klijent Klijent { get; set; }

        public ICollection<FakturaKonstrukcija> FakturaKonstrikcija { get; set; }
    }
}
