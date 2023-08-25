using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaliStrength.Models
{
    public class TipoEjercicio
    {
        public int Id { get; set; }

        [Required] public string Nombre { get; set; } = null!;

        public string Descripcion { get; set; } = null!;
    }    
}