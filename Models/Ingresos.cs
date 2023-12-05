using System.ComponentModel.DataAnnotations;

namespace Kissland_AP1.Models
{
    public class Ingresos
    {

        [Key]
        public int IngresoId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es necesario")]
        public string Concepto { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es necesario")]
        [Range(1, 25000, ErrorMessage = "El precio debe estar entre {1} y {2}")]
        public float Monto { get; set; }
    }
}
