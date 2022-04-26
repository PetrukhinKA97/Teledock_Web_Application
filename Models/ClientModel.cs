using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class ClientModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Inn { get; set; }
        [Required]
        public string Type { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required]
        public int UcheriditelNomer { get; set; }
    }
}
