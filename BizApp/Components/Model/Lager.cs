using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizApp.Components.Model
{
    [Table("Lageri", Schema = "dbo")]
    [Index(nameof(ProizvodID), IsUnique = true)]
    public class Lager
    {
        public int ID { get; set; }
        public int Kolicina { get; set; }
        public int ProizvodID { get; set; }
        [ForeignKey("ProizvodID")]
        public Proizvod Proizvod { get; set; }

    }
}
