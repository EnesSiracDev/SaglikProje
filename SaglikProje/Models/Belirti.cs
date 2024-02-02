using System.ComponentModel.DataAnnotations;

namespace SaglikProje.Models
{
    public class Belirti
    {
        [Key]
        public int BelirtiId { get; set; }
        [Required]
        public string Belirtiler { get; set; }
    }
}
