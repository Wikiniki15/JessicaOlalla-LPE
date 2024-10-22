using System.ComponentModel.DataAnnotations;

namespace JessicaOlalla_LPE.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        [Required]
        [StringLength(50)]
        public string NomEquipo { get; set; }
        [Required]
        [StringLength(20)]
        public string CiuEquipo { get; set; }
        [Required]
        [Range(0, 15)]
        public int Titulos { get; set; }
        [Required]
        public bool AcepExtr { get; set; }
        public ICollection<Jugador> jugador { get; set; }
    }
}
