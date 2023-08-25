using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaliStrength.Models
{
    public class Ejercicio
    {
        public int Id { get; set; }
    
        [Required]
        public int IdTipo { get; set; }

        [Required] public string Nombre { get; set; } = null!;

        [Required] public string Imagen { get; set; } = null!;

        [Required] public string Descripcion { get; set; } = null!;

        [Required] public string Instrucciones { get; set; } = null!;

    }    
}