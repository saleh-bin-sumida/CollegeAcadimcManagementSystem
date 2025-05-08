namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class CourseRepository : BaseRepository<Course>, ICourseRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<CourseRepository> _logger;

    public CourseRepository(AppDbContext context, ILogger<CourseRepository> logger) : base(context, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<BaseResponse<PagedResult<CourseDto>>> GetPagedCourses(
        int pageSize,
        int pageNumber,
        string? searchTerm = null)
    {
        Expression<Func<Course, bool>> filter = x => true;

        if (!string.IsNullOrEmpty(searchTerm))
        {
            filter = x => x.Title.Contains(searchTerm);
        }

        var courses = await GetPagedDataWithSelectionAsync<CourseDto>(
            orderBy: x => x.Title,
            criteria: filter,
            pageSize: pageSize,
            pageNumber: pageNumber);

        return BaseResponse<PagedResult<CourseDto>>.SuccessResponse("Courses retrieved successfully", courses);
    }


    public async Task<BaseResponse<IEnumerable<CourseDto>>> GetCoursesByInstrucotr(int instructorId)
    {
        if (!await _context.Instructors.AnyAsync(x => x.Id == instructorId))
            return BaseResponse<IEnumerable<CourseDto>>.ErrorResponse("instructor not found");


        var courses = await _context.DepStudyLevelCourseInstructors.Where(x => x.InstructorId == instructorId)
            .Select(x => new CourseDto
            {
                Id = x.DepStudyLevelCourse.CourseId,
                Title = x.DepStudyLevelCourse.Course.Title
            }).ToListAsync();

        return BaseResponse<IEnumerable<CourseDto>>.SuccessResponse("Courses retrieved successfully", courses);
    }

    public async Task<BaseResponse<IEnumerable<CourseDto>>> GetCoursesByDepStudyLevel(int depStudyLevelId)
    {

        var courses = await _context.DepartmentStudyLevelCourses
            .Where(x => x.DepartmentStudyLevelId == depStudyLevelId)
            .ProjectToType<CourseDto>().ToListAsync();


        return BaseResponse<IEnumerable<CourseDto>>.SuccessResponse("Courses retrieved successfully", courses);
    }


    public async Task<BaseResponse<CourseDto>> GetCourseById(int id)
    {
        var course = await FindWithSelectionAsync<CourseDto>(x => x.Id == id);
        if (course is null)
            return BaseResponse<CourseDto>.ErrorResponse("Course not found");

        return BaseResponse<CourseDto>.SuccessResponse("Course retrieved successfully", course);
    }

    public async Task<BaseResponse<string>> AddCourseAsync(AddCourseDto courseDto)
    {
        var course = courseDto.Adapt<Course>();
        _context.Add(course);
        _context.SaveChanges();

        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> UpdateCourseAsync(int id, UpdateCourseDto courseDto)
    {
        if (id != courseDto.Id)
            return BaseResponse<string>.ErrorResponse("Course not found");

        var course = await GetByIdAsync(id);

        course.Title = courseDto.Title;
        course.ModifiedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> DeleteCourseAsync(int id)
    {
        var course = await GetByIdAsync(id);

        if (course is null)
            return BaseResponse<string>.ErrorResponse("Course not found");

        await DeleteAsync(course);
        return BaseResponse<string>.SuccessResponse();
    }


}
