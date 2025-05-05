namespace CollegeAcadimcManagementSystem.EF.Data.EntitesConfiguration;

internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.ToTable(TablesNames.Instructors);


        builder.Property(e => e.FirstName)
            .HasMaxLength(50);

        builder.Property(e => e.LastName)
            .HasMaxLength(50);

        builder.Property(e => e.PhoneNumber)
            .HasMaxLength(20);

        builder.Property(e => e.Email)
            .HasMaxLength(255);

        // Global filter to exclude deleted clients
        builder.HasQueryFilter(e => !e.IsDeleted);

        builder.HasData(SeedData.SeedInstructors());
    }
}

