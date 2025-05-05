using CollegeAcadimcManagementSystem.EF.Data.Configuration;

namespace CollegeAcadimcManagementSystem.EF.Data;

public class AppDbContext : DbContext
{
    #region DbSets

    public DbSet<Student> Students { get; set; }

    #endregion

    #region Constructors

    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    #endregion

    #region OnModelCreating

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
    }

    #endregion
}

