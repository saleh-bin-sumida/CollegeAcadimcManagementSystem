using CollegeAcadimcManagementSystem.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollegeAcadimcManagementSystem.EF.Configurations;

public class DepStudyLevelCourseInstructorConfiguration : IEntityTypeConfiguration<DepStudyLevelCourseInstructor>
{
    public void Configure(EntityTypeBuilder<DepStudyLevelCourseInstructor> builder)
    {
        builder.ToTable(TablesNames.DepStudyLevelCourseInstructors);

        builder.HasKey(d => d.Id);

        builder.HasOne(d => d.Instructor)
            .WithMany(i => i.DepStudyLevelCourseInstructors)
            .HasForeignKey(d => d.InstructorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(d => d.DepStudyLevelCourse)
            .WithMany(c => c.DepStudyLevelCourseInstructors)
            .HasForeignKey(d => d.DepStudyLevelCourseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
