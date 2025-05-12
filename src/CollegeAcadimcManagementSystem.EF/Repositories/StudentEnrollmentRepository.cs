namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class StudentEnrollmentRepository : IStudentEnrollmentRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<StudentEnrollmentRepository> _logger;

    public StudentEnrollmentRepository(AppDbContext context, ILogger<StudentEnrollmentRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public BaseResponse<List<StudentEnrollmentDto>> GetByStudentId(int studentId)
    {
        var enrollments = _context.StudentEnrollments
            .Where(e => e.StudentId == studentId)
            .Select(e => new StudentEnrollmentDto
            {
                StudentName = $"{e.Student.FirstName} {e.Student.LastName}",
                Grade = e.Grade,
                Date = e.Date
            })
            .ToList();

        return BaseResponse<List<StudentEnrollmentDto>>.SuccessResponse("Enrollments retrieved successfully", enrollments);
    }

    public BaseResponse<List<StudentEnrollmentDto>> GetByDepStudyLevelId(int depStudyLevelId)
    {
        var offerCouesIds = _context.OfferedCourses.Where(x => x.DepartmentStudyLevelId == depStudyLevelId).Select(x => x.Id);

        var enrollments = _context.StudentEnrollments.Where(x => offerCouesIds.Contains(x.OfferedCourseId))
            .Select(e => new StudentEnrollmentDto
            {
                StudentName = $"{e.Student.FirstName} {e.Student.LastName}",
                Grade = e.Grade,
                Date = e.Date
            })
            .ToList();

        return BaseResponse<List<StudentEnrollmentDto>>.SuccessResponse("Enrollments retrieved successfully", enrollments);
    }

    public BaseResponse<List<StudentEnrollmentDto>> GetByOfferedCourseId(int offeredCourseId)
    {
        var enrollments = _context.StudentEnrollments.Where(x => x.OfferedCourseId == offeredCourseId)
            .Select(e => new StudentEnrollmentDto
            {
                StudentName = $"{e.Student.FirstName} {e.Student.LastName}",
                Grade = e.Grade,
                Date = e.Date
            })
            .ToList();

        return BaseResponse<List<StudentEnrollmentDto>>.SuccessResponse("Enrollments retrieved successfully", enrollments);

    }
}
