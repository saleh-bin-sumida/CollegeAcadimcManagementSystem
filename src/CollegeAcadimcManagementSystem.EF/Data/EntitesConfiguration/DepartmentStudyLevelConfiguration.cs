namespace CollegeAcadimcManagementSystem.EF.Data.Configuration;

internal class DepartmentStudyLevelConfiguration : IEntityTypeConfiguration<DepartmentStudyLevel>
{
    public void Configure(EntityTypeBuilder<DepartmentStudyLevel> builder)
    {
        builder.ToTable(TablesNames.DepartmentStudyLevels);

        builder.HasKey(dsl => new { dsl.DepartmentId, dsl.StudyLevelId });

        builder.HasOne(dsl => dsl.Department)
            .WithMany(d => d.DepartmentStudyLevels)
            .HasForeignKey(dsl => dsl.DepartmentId);

        builder.HasOne(dsl => dsl.StudyLevel)
            .WithMany(sl => sl.DepartmentStudyLevels)
            .HasForeignKey(dsl => dsl.StudyLevelId);

        builder.HasData(SeedData.SeedDepartmentStudyLevels());
    }
}
