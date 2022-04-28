using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    [Keyless]
    public class LegalEntityModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int UcheriditelNomer { get; set; }
    }
}
