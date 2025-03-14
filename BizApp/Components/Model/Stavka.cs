using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{

    [Table("Stavke", Schema = "dbo")]
    public class Stavka
    {
        public int ID { get; set; }
        public int FakturaKonstrukcijaID { get; set; }
        [ForeignKey("FakturaKonstrukcijaID")]
        public FakturaKonstrukcija FakturaKonstrukcija { get; set; }
        public int ProizvodID{ get; set; }
        [ForeignKey("ProizvodID")]
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
        public bool? Naručeno { get; set; }
        public bool? Montirano{ get; set; }

}
}
