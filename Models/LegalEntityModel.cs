using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    //[Keyless]
    public class LegalEntityModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<UcheriditelModel> UcheriditelNomer { get; set; }
    }
}
