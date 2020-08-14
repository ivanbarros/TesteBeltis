using Microsoft.EntityFrameworkCore;
using TecBan.Domain.Entities;

namespace TecBan.Data.Context
{
    public class EFDbContext : DbContext
    {
        public DbSet<ATM> atms { get; set; }
        public DbSet<Municipios> municipios { get; set; }
        public DbSet<UFS> ufs { get; set; }

        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

