namespace CollegeAcadimcManagementSystem.EF.Data.EntitesConfiguration;
class DepStudyLevelCourseInstructorConfiguration : IEntityTypeConfiguration<DepStudyLevelCourseInstructor>
{
    public void Configure(EntityTypeBuilder<DepStudyLevelCourseInstructor> builder)
    {
        builder.ToTable(TablesNames.DepStudyLevelCourseInstructors);

        builder.HasKey(cdsl => cdsl.Id);

        builder.HasOne(cdsl => cdsl.Instructor)
            .WithMany(c => c.DepStudyLevelCourseInstructors)
            .HasForeignKey(cdsl => cdsl.InstructorId);

        builder.HasOne(cdsl => cdsl.DepStudyLevelCourse)
            .WithMany(c => c.DepStudyLevelCourseInstructors)
            .HasForeignKey(cdsl => cdsl.DepStudyLevelCourseId);

        builder.HasQueryFilter(x => !x.Instructor.IsDeleted);
        builder.HasData(SeedData.SeedDepStudyLevelCourseInstructors());
    }
}
