using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class LegalEntityModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int UcheriditelNomer { get; set; }
    }
}
