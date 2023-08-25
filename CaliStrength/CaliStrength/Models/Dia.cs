using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaliStrength.Models
{
    public class Dia
    {
        public int Id { get; set; }
    
        [Required]
        public int IdUsuario { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }    
}