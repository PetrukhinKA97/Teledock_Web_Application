using Microsoft.EntityFrameworkCore;
using Teledock_Web_Application.Models;

namespace Teledock_Web_Application.Connection
{
    public class ConnectionDatabase:DbContext
    {
        public ConnectionDatabase(DbContextOptions<ConnectionDatabase> options) : base(options)
        {

        }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<LegalEntityModel> LegalEntity { get; set; }
        public DbSet<UcheriditelModel> Ucheriditel { get; set; }



    }
}
