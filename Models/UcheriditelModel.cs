using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class UcheriditelModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Fio { get; set; }
        [Required]
        public string Inn { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required]
        public int UcheriditelNomer { get; set; }
    }
}
