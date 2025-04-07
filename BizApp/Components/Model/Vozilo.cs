using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace BizApp.Components.Model
{
    [Table("Vozila", Schema = "dbo")]
    public class Vozilo
    {
        public int ID { get; set; }
        [MaxLength(32)]
        public string Proizvodjac { get; set; } = string.Empty;
        [MaxLength(32)]
        public string Model { get; set; } = string.Empty;

        [MaxLength(8)] 
        public string Registracija { get; set; } = string.Empty;
        public DateOnly DatumIstekaRegistracije { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [NotMapped] 
        public int IstekRegistracijeUDanima => (DatumIstekaRegistracije.ToDateTime(new TimeOnly(0, 0, 0)) - DateTime.Today).Days;
        
        public DateOnly DatumIstekaProtivPozarnogAparata { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public bool ProtivProzarniAparat { get; set; } = true;
        [NotMapped] public int IstekPPAparataUDanima => (DatumIstekaProtivPozarnogAparata.AddMonths(6).ToDateTime(new TimeOnly(0, 0, 0)) - DateTime.Today).Days;
        public DateOnly DatumIstekaPrvePomoci { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public bool PrvaPomoc { get; set; } = true;
        [NotMapped] public int IstekPrvePomociUDanima => (DatumIstekaPrvePomoci.ToDateTime(new TimeOnly(0, 0, 0)) - DateTime.Today).Days;

    }
}
