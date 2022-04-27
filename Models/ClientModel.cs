using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class ClientModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Type { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UcheriditelNomer { get; set; }
    }
}
