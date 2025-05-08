using CollegeAcadimcManagementSystem.EF.Data.Configuration;

namespace CollegeAcadimcManagementSystem.EF.Data;

public class AppDbContext : DbContext
{
    #region DbSets

    public DbSet<Student> Students { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Department> Departments { get; set; } // Added Departments DbSet
    public DbSet<StudyLevel> StudyLevels { get; set; } // Added StudyLevels DbSet
    public DbSet<DepartmentStudyLevel> DepartmentStudyLevels { get; set; } // Added join entity DbSet
    //public DbSet<Course> Courses { get; set; }
    //public DbSet<DepartmentStudyLevelCourse> CourseDepartmentStudyLevels { get; set; }

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

