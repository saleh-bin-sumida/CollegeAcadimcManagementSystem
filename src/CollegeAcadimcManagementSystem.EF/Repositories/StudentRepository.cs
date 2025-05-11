namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<StudentRepository> _logger;

    public StudentRepository(AppDbContext context, ILogger<StudentRepository> logger) : base(context, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<BaseResponse<PagedResult<StudentDto>>> GetPagedStudents(
        int pageSize,
        int pageNumber,
        string? searchTerm = null)
    {

        Expression<Func<Student, bool>> filter = x => true;

        if (!string.IsNullOrEmpty(searchTerm))
        {
            filter = x => x.FirstName.Contains(searchTerm) || x.LastName.Contains(searchTerm)
            || x.Email.Contains(searchTerm) || x.PhoneNumber.Contains(searchTerm);
        }

        var students = await GetPagedDataWithSelectionAsync<StudentDto>(
            orderBy: x => x.FirstName,
            criteria: filter,
            pageSize: pageSize,
            pageNumber: pageNumber);

        return BaseResponse<PagedResult<StudentDto>>.SuccessResponse("student retrived succfully", students);
    }


    public async Task<BaseResponse<PagedResult<StudentDto>>> GetStudentsByDepartment(
        int departmentId,
        int pageSize,
        int pageNumber,
        string? searchTerm)
    {
        if (!await _context.Departments.AnyAsync(x => x.Id == departmentId))
            return BaseResponse<PagedResult<StudentDto>>.ErrorResponse("department not found");

        var depStudyLevelsIds = _context.DepartmentStudyLevels
            .Where(x => x.DepartmentId == departmentId)
            .Select(x => x.Id);



        var depStudyLevelCourseIds = _context.DepartmentStudyLevelCourses
            .Where(x => depStudyLevelsIds.Contains(x.DepartmentStudyLevelId))
            .Select(x => x.Id);


        var query = _context.StudentEnrollments
            .Where(x => depStudyLevelCourseIds.Contains(x.DepartmentStudyLevelCourseId))
            .ProjectToType<StudentDto>();



        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(x => x.FullName.Contains(searchTerm)
            || x.Email.Contains(searchTerm) ||
            x.PhoneNumber.Contains(searchTerm));
        }

        var pagedResult = await GetPagedResultAsync(query, pageSize, pageNumber);

        return BaseResponse<PagedResult<StudentDto>>.SuccessResponse("students retrieved successfully", pagedResult);
    }



    public async Task<BaseResponse<PagedResult<StudentDto>>> GetStudentsByDepartmentStudyLevel(
        int departmentStudyLevelId,
        int pageSize,
        int pageNumber,
        string? searchTerm)
    {
        if (!await _context.DepartmentStudyLevels.AnyAsync(x => x.Id == departmentStudyLevelId))
            return BaseResponse<PagedResult<StudentDto>>.ErrorResponse("department Study Level not found");


        var departmentStudyLevelCourseIds = _context.DepartmentStudyLevelCourses
            .Where(x => x.DepartmentStudyLevelId == departmentStudyLevelId)
            .Select(x => x.Id);

        var query = _context.StudentEnrollments
            .Where(x => departmentStudyLevelCourseIds.Contains(x.DepartmentStudyLevelCourseId))
            .Select(x => new StudentDto
            {
                Id = x.StudentId,
                FullName = x.Student.FirstName + " " + x.Student.LastName,
                Email = x.Student.Email,
                PhoneNumber = x.Student.PhoneNumber,
            });

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(x => x.FullName.Contains(searchTerm)
            || x.Email.Contains(searchTerm) || x.PhoneNumber.Contains(searchTerm));
        }

        var pagedResult = await GetPagedResultAsync(query, pageSize, pageNumber);

        return BaseResponse<PagedResult<StudentDto>>.SuccessResponse("students retrieved successfully", pagedResult);
    }


    public async Task<BaseResponse<StudentDto>> GetStudentById(int id)
    {
        var student = await FindWithSelectionAsync<StudentDto>(x => x.Id == id);
        if (student is null)
            return BaseResponse<StudentDto>.ErrorResponse("student not found");

        return BaseResponse<StudentDto>.SuccessResponse("student retrived succfully", student);
    }


    public async Task<BaseResponse<string>> AddStudentAsync(AddStudentDto studentDto)
    {

        var student = studentDto.Adapt<Student>();
        _context.Add(student);
        _context.SaveChanges();

        return BaseResponse<string>.SuccessResponse();
    }


    public async Task<BaseResponse<string>> UpdateStudentAsync(int id, UpdateStudentDto studentDto)
    {

        if (id != studentDto.Id)
            return BaseResponse<string>.ErrorResponse("student not found");

        var student = await GetByIdAsync(id);

        student.FirstName = studentDto.FirstName;
        student.LastName = studentDto.LastName;
        student.Email = studentDto.Email;
        student.PhoneNumber = studentDto.PhoneNumber;
        student.ModifiedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return BaseResponse<string>.SuccessResponse();
    }



    public async Task<BaseResponse<string>> DeleteStudentAsync(int id)
    {
        var student = await GetByIdAsync(id);

        if (student is null)
            return BaseResponse<string>.ErrorResponse("student not found");

        await DeleteAsync(student);
        return BaseResponse<string>.SuccessResponse();

    }

}
