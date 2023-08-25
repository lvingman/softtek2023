using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaliStrength.Models
{
    public class Desempeno
    {
        public int Id { get; set; }
    
        [Required]
        public int IdDia { get; set; }
    
        [Required]
        public int IdEjercicio { get; set; }
        
        public string RepesSerie1 { get; set; }
        public string RepesSerie2 { get; set; }
        public string RepesSerie3 { get; set; }
        
        public int Valoracion { get; set; }
        
    }    
}