namespace CollegeAcadimcManagementSystem.EF.Data.EntitesConfiguration;
class CourseInstructorAssignmentConfiguration : IEntityTypeConfiguration<CourseInstructorAssignment>
{
    public void Configure(EntityTypeBuilder<CourseInstructorAssignment> builder)
    {
        builder.ToTable(TablesNames.CourseInstructorAssignments);

        builder.HasKey(cdsl => cdsl.Id);

        builder.HasOne(cdsl => cdsl.Instructor)
            .WithMany(c => c.CourseInstructorAssignments)
            .HasForeignKey(cdsl => cdsl.InstructorId);

        builder.HasOne(cdsl => cdsl.OfferedCourse)
            .WithMany(c => c.CourseInstructorAssignments)
            .HasForeignKey(cdsl => cdsl.OfferedCourseId);

        builder.HasQueryFilter(x => !x.Instructor.IsDeleted);
        builder.HasData(SeedData.CourseInstructorAssignments());
    }
}
