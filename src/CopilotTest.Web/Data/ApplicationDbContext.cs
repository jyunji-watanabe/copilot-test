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
            new SampleEntity { Id = 1, Name = "Sample 1", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
            new SampleEntity { Id = 2, Name = "Sample 2", CreatedAt = new DateTime(2024, 1, 2, 0, 0, 0, DateTimeKind.Utc) }
        );
    }
}
