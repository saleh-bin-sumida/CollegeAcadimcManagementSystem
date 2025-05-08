namespace CollegeAcadimcManagementSystem.EF.Data.Configuration;

internal class StudyLevelConfiguration : IEntityTypeConfiguration<StudyLevel>
{
    public void Configure(EntityTypeBuilder<StudyLevel> builder)
    {
        builder.ToTable(TablesNames.StudyLevels);

        builder.Property(e => e.Name)
            .HasMaxLength(100);

        // Global filter to exclude deleted study levels
        builder.HasQueryFilter(e => !e.IsDeleted);

        builder.HasMany(sl => sl.DepartmentStudyLevels)
            .WithOne(dsl => dsl.StudyLevel)
            .HasForeignKey(dsl => dsl.StudyLevelId);

        builder.HasData(SeedData.SeedStudyLevels());
    }
}
