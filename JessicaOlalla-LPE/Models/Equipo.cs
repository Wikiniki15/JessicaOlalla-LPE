using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JessicaOlalla_LPE.Models
{
    public class Equipo
    {
        [Key]
        public int Id_Equipo { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre_Equipo { get; set; }
        [Required]
        [StringLength(20)]
        public string Ciudad_Equipo { get; set; }
        [Required]
        [Range(0, 15)]
        public int Titulos { get; set; }
        [ForeignKey("EstadioId")]
        public int EstadioId { get; set; }
        public Estadio? estadio { get; set; }
        [Required]
        public bool Acepta_Extranjeros { get; set; }
    }
}
