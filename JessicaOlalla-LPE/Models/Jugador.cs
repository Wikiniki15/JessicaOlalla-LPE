using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JessicaOlalla_LPE.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador {  get; set; }
        [Required]
        [StringLength(50)]
        public string NomJugador { get; set; }
        [Required]
        [StringLength(30)]
        public string Posicion {  get; set; }
        [Required]
        [Range(10, 40)]
        public int Edad {  get; set; }
        [ForeignKey("EquipoId")]
        public int EquipoId { get; set; }
        public Equipo equipo { get; set; }
    }
}
