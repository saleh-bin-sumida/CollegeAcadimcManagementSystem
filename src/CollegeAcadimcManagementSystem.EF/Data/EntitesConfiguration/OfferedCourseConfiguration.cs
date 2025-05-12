namespace CollegeAcadimcManagementSystem.EF.Data.Configuration;

internal class OfferedCourseConfiguration : IEntityTypeConfiguration<OfferedCourse>
{
    public void Configure(EntityTypeBuilder<OfferedCourse> builder)
    {
        builder.ToTable(TablesNames.OfferedCourses);

        builder.HasKey(cdsl => cdsl.Id);

        builder.HasOne(cdsl => cdsl.Course)
            .WithMany(c => c.OfferedCourses)
            .HasForeignKey(cdsl => cdsl.CourseId);

        builder.HasOne(cdsl => cdsl.DepartmentStudyLevel)
            .WithMany(c => c.OfferedCourses)
            .HasForeignKey(cdsl => cdsl.DepartmentStudyLevelId);

        builder.HasQueryFilter(x => !x.Course.IsDeleted);
        builder.HasData(SeedData.OfferedCourses());
    }
}
