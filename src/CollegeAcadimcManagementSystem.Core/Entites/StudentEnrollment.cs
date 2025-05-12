namespace CollegeAcadimcManagementSystem.Core.Entites;

public class StudentEnrollment
{
    public int Id { get; set; }
    public float Grade { get; set; }
    public DateOnly Date { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int OfferedCourseId { get; set; }
    public OfferedCourse OfferedCourses { get; set; }
}
