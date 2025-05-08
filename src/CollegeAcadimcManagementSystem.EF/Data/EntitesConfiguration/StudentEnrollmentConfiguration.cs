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

        builder.HasOne(se => se.DepartmentStudyLevel)
            .WithMany(x => x.StudentEnrollments)
            .HasForeignKey(se => se.DepartmentStudyLevelId);
        builder.HasData(SeedData.SeedStudentEnrollments());
    }
}
