using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet <Serviciu> Servicii { get; set; }
        public DbSet <Solicitare> Solicitari { get; set; }
        public DbSet <Status> Statusuri { get; set; }
        public DbSet <Unitate> Unitati { get; set; }

    }
}