using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Teledock_Web_Application.Models
{
    public class LegalEntityModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int UcheriditelNomer { get; set; }
    }
}
