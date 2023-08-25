using System.ComponentModel.DataAnnotations;

namespace CaliStrength.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required] public string Nombre { get; set; } = null!;

        [Required] public string Contrasena { get; set; } = null!;

        [Required] public string Email { get; set; } = null!;
    }    
 }
