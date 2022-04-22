using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class LegalEntityModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UcheriditelNomer { get; set; }
    }
}
