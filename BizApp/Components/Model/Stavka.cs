using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{

    [Table("Stavke", Schema = "dbo")]
    public class Stavka
    {
        public int ID { get; set; }
        public int FakturaID { get; set; }
        [ForeignKey("FakturaID")]
        public Faktura Faktura{ get; set; }
        public int ProizvodID{ get; set; }
        [ForeignKey("ProizvodID")]
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
        public bool? Naruceno { get; set; }
        public bool? Montirano{ get; set; }
        public int? Cena { get; set; }

    }
}
