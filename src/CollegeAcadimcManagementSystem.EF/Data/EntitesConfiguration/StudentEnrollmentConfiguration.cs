namespace CollegeAcadimcManagementSystem.EF.Data.EntitesConfiguration;

internal class StudentEnrollmentConfiguration : IEntityTypeConfiguration<StudentEnrollment>
{
    public void Configure(EntityTypeBuilder<StudentEnrollment> builder)
    {
        builder.ToTable(TablesNames.StudentEnrollments);

        builder.HasKey(se => se.Id);

        builder.HasOne(se => se.Student)
            .WithMany(x => x.StudentEnrollments)
            .HasForeignKey(se => se.StudentId);

        builder.HasOne(se => se.OfferedCourses)
            .WithMany(x => x.StudentEnrollments)
            .HasForeignKey(se => se.OfferedCourseId);
        builder.HasData(SeedData.SeedStudentEnrollments());
    }
}
