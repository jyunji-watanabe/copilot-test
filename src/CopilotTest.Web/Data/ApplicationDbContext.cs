using Microsoft.EntityFrameworkCore;

namespace CopilotTest.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<SampleEntity> SampleEntities { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<SampleEntity>().HasData(
            new SampleEntity { Id = 1, Name = "Sample 1", CreatedAt = DateTime.UtcNow },
            new SampleEntity { Id = 2, Name = "Sample 2", CreatedAt = DateTime.UtcNow }
        );
    }
}
