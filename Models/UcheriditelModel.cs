using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class UcheriditelModel
    {
        [Key]
        public int Id { get; set; }
        public string Fio { get; set; }
        public string Inn { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UcheriditelNomer { get; set; }
    }
}
