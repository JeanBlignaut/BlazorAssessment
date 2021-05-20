using Microsoft.EntityFrameworkCore;
using Tng.TechnicalEvaluation.Infrastructure.Models;

namespace Tng.TechnicalEvaluation.Infrastructure.Contexts
{
    public class BOMContext : DbContext
    {
        public BOMContext(DbContextOptions<BOMContext> options) 
            : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Part>()
                .Property(o => o.Cost)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Part> Parts { get; set; }
    }
}