using System.ComponentModel.DataAnnotations;

namespace JessicaOlalla_LPE.Models
{
    public class Estadio
    {
        [Key]
        public int Id_Estadio { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre_Estadio { get; set; }
        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Required]
        [StringLength(50)]
        public string Ciudad_Estadio { get; set; }
        [Required]
        [Range(1, 70000)]
        public int Capacidad { get; set; }

    }
}
