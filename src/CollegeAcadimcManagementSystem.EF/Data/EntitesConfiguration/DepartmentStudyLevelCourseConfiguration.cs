namespace CollegeAcadimcManagementSystem.EF.Data.Configuration;

internal class DepartmentStudyLevelCourseConfiguration : IEntityTypeConfiguration<DepartmentStudyLevelCourse>
{
    public void Configure(EntityTypeBuilder<DepartmentStudyLevelCourse> builder)
    {
        builder.ToTable(TablesNames.DepartmentStudyLevelCourses);

        builder.HasKey(cdsl => cdsl.Id);

        builder.HasOne(cdsl => cdsl.Course)
            .WithMany(c => c.DepartmentStudyLevelCourses)
            .HasForeignKey(cdsl => cdsl.CourseId);

        builder.HasOne(cdsl => cdsl.DepartmentStudyLevel)
            .WithMany(c => c.DepartmentStudyLevelCourses)
            .HasForeignKey(cdsl => cdsl.DepartmentStudyLevelId);

        builder.HasQueryFilter(x => !x.Course.IsDeleted);
        builder.HasData(SeedData.SeedDepartmentStudyLevelCourses());
    }
}
