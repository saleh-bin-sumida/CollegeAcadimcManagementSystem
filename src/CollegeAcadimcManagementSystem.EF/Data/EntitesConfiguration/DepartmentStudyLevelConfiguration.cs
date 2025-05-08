namespace CollegeAcadimcManagementSystem.EF.Data.Configuration;

internal class DepartmentStudyLevelConfiguration : IEntityTypeConfiguration<DepartmentStudyLevel>
{
    public void Configure(EntityTypeBuilder<DepartmentStudyLevel> builder)
    {
        builder.ToTable(TablesNames.DepartmentStudyLevels);

        builder.HasKey(dsl => dsl.Id);

        builder.HasOne(dsl => dsl.Department)
            .WithMany(d => d.DepartmentStudyLevels)
            .HasForeignKey(dsl => dsl.DepartmentId);

        builder.HasOne(dsl => dsl.StudyLevel)
            .WithMany(sl => sl.DepartmentStudyLevels)
            .HasForeignKey(dsl => dsl.StudyLevelId);

        builder.HasQueryFilter(e => !e.StudyLevel.IsDeleted && !e.Department.IsDeleted);


        builder.HasData(SeedData.SeedDepartmentStudyLevels());
    }
}
