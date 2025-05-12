namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IStudentRepository Students { get; }
    IInstructorsRepository Instructors { get; }
    IDepartmentRepository Departments { get; }
    IStudyLevelRepository StudyLevels { get; }
    ICourseRepository Courses { get; }
    IDepartmentStudyLevelRepo DepartmentStudyLevels { get; }
    IStudentEnrollmentRepository StudentEnrollments { get; }
    Task<int> SaveAsync();
}

