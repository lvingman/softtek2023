using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaliStrength.Models
{
    public class Requisito
    {
        public int Id { get; set; }

        [Required] 
        public int IdEjercicio { get; set; }
    }    
}