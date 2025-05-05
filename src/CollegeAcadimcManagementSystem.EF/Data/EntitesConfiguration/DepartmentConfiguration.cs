namespace CollegeAcadimcManagementSystem.EF.Data.Configuration;

internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable(TablesNames.Departments);

        builder.Property(e => e.Name)
            .HasMaxLength(100);

        builder.Property(e => e.Description)
            .HasMaxLength(500);

        // Global filter to exclude deleted departments
        builder.HasQueryFilter(e => !e.IsDeleted);

        builder.HasData(SeedData.SeedDepartments());
    }
}
