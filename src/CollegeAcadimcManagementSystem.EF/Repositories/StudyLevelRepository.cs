namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class StudyLevelRepository : BaseRepository<StudyLevel>, IStudyLevelRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<StudyLevelRepository> _logger;

    public StudyLevelRepository(AppDbContext context, ILogger<StudyLevelRepository> logger) : base(context, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<BaseResponse<PagedResult<StudyLevelDto>>> GetPagedStudyLevels(
        int pageSize,
        int pageNumber,
        string? searchTerm = null)
    {
        Expression<Func<StudyLevel, bool>> filter = x => true;

        if (!string.IsNullOrEmpty(searchTerm))
        {
            filter = x => x.Name.Contains(searchTerm);
        }

        var studyLevels = await GetPagedDataWithSelectionAsync<StudyLevelDto>(
            orderBy: x => x.Name,
            criteria: filter,
            pageSize: pageSize,
            pageNumber: pageNumber);

        return BaseResponse<PagedResult<StudyLevelDto>>.SuccessResponse("Study levels retrieved successfully", studyLevels);
    }

    public async Task<BaseResponse<List<StudyLevelDto>>> GetStudyLevelsByDepartmentAsync(int departmentId)
    {
        if (!await AnyAsync(x => x.Id == departmentId))
            return BaseResponse<List<StudyLevelDto>>.ErrorResponse("Department not found");


        //  deparmtes => departmentsStudyLevels => levels
        //var DepStudyLevels = await _context
        //    .Departments.Where(x => x.Id == departmentId)
        //    .SelectMany(dep => dep.DepartmentStudyLevels.Select(x => x.StudyLevel))
        //    .ProjectToType<DepartmentStudyLevelDto>().ToListAsync();


        // deparmtes => departmentsStudyLevels => levels
        var DepStudyLevels = await _context
            .DepartmentStudyLevels.Where(x => x.DepartmentId == departmentId)
            .Select(x => new StudyLevelDto
            {
                Id = x.StudyLevelId,
                Name = x.StudyLevel.Name
            }).ToListAsync();

        return BaseResponse<List<StudyLevelDto>>.SuccessResponse("Study levels retrieved successfully", DepStudyLevels);
    }

    public async Task<BaseResponse<List<StudyLevelDto>>> GetStudyLevelsByCourseAsync(int courseId)
    {
        if (!await _context.Courses.AnyAsync(x => x.Id == courseId))
            return BaseResponse<List<StudyLevelDto>>.ErrorResponse("course not found");

        var studyLevels = await _context.DepartmentStudyLevelCourses.Where(x => x.CourseId == courseId)
            .Select(x => x.DepartmentStudyLevel.StudyLevel).Distinct()
            .Select(x => new StudyLevelDto
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

        return BaseResponse<List<StudyLevelDto>>.SuccessResponse("Study level retrieved successfully", studyLevels);

    }

    public async Task<BaseResponse<StudyLevelDto>> GetStudyLevelById(int id)
    {
        var studyLevel = await FindWithSelectionAsync<StudyLevelDto>(x => x.Id == id);
        if (studyLevel is null)
            return BaseResponse<StudyLevelDto>.ErrorResponse("Study level not found");

        return BaseResponse<StudyLevelDto>.SuccessResponse("Study level retrieved successfully", studyLevel);
    }

    public async Task<BaseResponse<string>> AddStudyLevelAsync(AddStudyLevelDto studyLevelDto)
    {
        var studyLevel = studyLevelDto.Adapt<StudyLevel>();
        _context.Add(studyLevel);
        await _context.SaveChangesAsync();

        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> UpdateStudyLevelAsync(int id, UpdateStudyLevelDto studyLevelDto)
    {
        if (id != studyLevelDto.Id)
            return BaseResponse<string>.ErrorResponse("Study level not found");

        var studyLevel = await GetByIdAsync(id);

        studyLevel.Name = studyLevelDto.Name;
        studyLevel.ModifiedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> DeleteStudyLevelAsync(int id)
    {
        var studyLevel = await GetByIdAsync(id);

        if (studyLevel is null)
            return BaseResponse<string>.ErrorResponse("Study level not found");

        await DeleteAsync(studyLevel);
        return BaseResponse<string>.SuccessResponse();
    }


}
