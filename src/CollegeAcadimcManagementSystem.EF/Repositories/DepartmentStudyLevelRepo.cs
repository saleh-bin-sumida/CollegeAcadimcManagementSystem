namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class DepartmentStudyLevelRepo : BaseRepository<DepartmentStudyLevel>, IDepartmentStudyLevelRepo
{
    AppDbContext _context;
    ILogger<DepartmentStudyLevelRepo> _logger;

    public DepartmentStudyLevelRepo(AppDbContext context, ILogger<DepartmentStudyLevelRepo> logger)
        : base(context, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetDepartmentStudyLevelsByCourse(int courseId)
    {
        if (!await _context.Courses.AnyAsync(x => x.Id == courseId))
            return BaseResponse<List<DepartmentStudyLevelDto>>.ErrorResponse("course not found");

        var depStudyLevels = await _context.DepartmentStudyLevelCourses.Where(x => x.CourseId == courseId)
            .Select(x => x.DepartmentStudyLevel).ProjectToType<DepartmentStudyLevelDto>().ToListAsync();

        return BaseResponse<List<DepartmentStudyLevelDto>>.SuccessResponse("Department StudyLevels retrieved successfully", depStudyLevels);

    }

    public async Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetAllDepartmentStudyLevels()
    {
        var depStudyLevels = await _context.DepartmentStudyLevels
            .ProjectToType<DepartmentStudyLevelDto>()
            .ToListAsync();

        return BaseResponse<List<DepartmentStudyLevelDto>>.SuccessResponse(
            "All Department StudyLevels retrieved successfully", depStudyLevels);
    }

    public async Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetDepartmentStudyLevelsByStudyLevel(int studyLevelId)
    {
        if (!await _context.StudyLevels.AnyAsync(x => x.Id == studyLevelId))
            return BaseResponse<List<DepartmentStudyLevelDto>>.ErrorResponse("Study level not found");

        var depStudyLevels = await _context.DepartmentStudyLevels
            .Where(x => x.StudyLevelId == studyLevelId)
            .ProjectToType<DepartmentStudyLevelDto>()
            .ToListAsync();

        return BaseResponse<List<DepartmentStudyLevelDto>>.SuccessResponse(
            "Department StudyLevels retrieved successfully", depStudyLevels);
    }

    public async Task<BaseResponse<List<DepartmentStudyLevelDto>>> GetDepartmentStudyLevelsByDepartment(int departmentId)
    {
        if (!await _context.Departments.AnyAsync(x => x.Id == departmentId))
            return BaseResponse<List<DepartmentStudyLevelDto>>.ErrorResponse("Department not found");

        var depStudyLevels = await _context.DepartmentStudyLevels
            .Where(x => x.DepartmentId == departmentId)
            .ProjectToType<DepartmentStudyLevelDto>()
            .ToListAsync();

        return BaseResponse<List<DepartmentStudyLevelDto>>.SuccessResponse(
            "Department StudyLevels retrieved successfully", depStudyLevels);
    }

}
