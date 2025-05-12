namespace CollegeAcadimcManagementSystem.Core.Interfaces
{
    interface IStudentEnrollment
    {
        IEnumerable<StudentEnrollment> GetByStudentId(int studentId);
        IEnumerable<StudentEnrollment> GetByDepStudyLevelId(int depStudyLevelId);
        IEnumerable<StudentEnrollment> GetByOfferedCourseId(int offeredCourseId);
    }
}