namespace CollegeAcadimcManagementSystem.Core.Entites;

public class OfferedCourse
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int DepartmentStudyLevelId { get; set; }
    public DepartmentStudyLevel DepartmentStudyLevel { get; set; }


    public ICollection<CourseInstructorAssignment> CourseInstructorAssignments = [];
    public ICollection<StudentEnrollment> StudentEnrollments = [];
}
