namespace CollegeAcadimcManagementSystem.Core.DTOs
{
    public class CourseInstructorAssignmentDto
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }
        public string OfferedCourseName { get; set; }
        public DateOnly Date { get; set; }
    }
}
