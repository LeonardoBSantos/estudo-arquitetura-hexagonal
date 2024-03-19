using System.ComponentModel.DataAnnotations;

namespace Domain.entities
{
    public class Entity1
    {
        [Key]
        public string IdExemplo { get; set; }
        public int IntA { get; set; }
        public int IntB { get; set; }
    }
}
