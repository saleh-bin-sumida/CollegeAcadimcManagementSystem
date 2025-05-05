namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class InstructorRepository : BaseRepository<Instructor>, IInstructorsRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<InstructorRepository> _logger;

    public InstructorRepository(AppDbContext context, ILogger<InstructorRepository> logger) : base(context, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<BaseResponse<PagedResult<InstructorDto>>> GetPagedInstructors(
        int pageSize,
        int pageNumber,
        string? searchTerm = null)
    {
        Expression<Func<Instructor, bool>> filter = x => true;

        if (!string.IsNullOrEmpty(searchTerm))
        {
            filter = x => x.FirstName.Contains(searchTerm) || x.LastName.Contains(searchTerm)
            || x.Email.Contains(searchTerm) || x.PhoneNumber.Contains(searchTerm);
        }

        var instructors = await GetPagedDataWithSelectionAsync<InstructorDto>(
            orderBy: x => x.FirstName,
            criteria: filter,
            pageSize: pageSize,
            pageNumber: pageNumber);

        return BaseResponse<PagedResult<InstructorDto>>.SuccessResponse("Instructors retrieved successfully", instructors);
    }

    public async Task<BaseResponse<InstructorDto>> GetInstructorById(int id)
    {
        var instructor = await FindWithSelectionAsync<InstructorDto>(x => x.Id == id);
        if (instructor is null)
            return BaseResponse<InstructorDto>.ErrorResponse("Instructor not found");

        return BaseResponse<InstructorDto>.SuccessResponse("Instructor retrieved successfully", instructor);
    }

    public async Task<BaseResponse<string>> AddInstructorAsync(AddInstructorDto instructorDto)
    {
        var instructor = instructorDto.Adapt<Instructor>();
        _context.Add(instructor);
        _context.SaveChanges();

        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> UpdateInstructorAsync(int id, UpdateInstructorDto instructorDto)
    {
        if (id != instructorDto.Id)
            return BaseResponse<string>.ErrorResponse("Instructor not found");

        var instructor = await GetByIdAsync(id);

        instructor.FirstName = instructorDto.FirstName;
        instructor.LastName = instructorDto.LastName;
        instructor.Email = instructorDto.Email;
        instructor.PhoneNumber = instructorDto.PhoneNumber;
        instructor.ModifiedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> DeleteInstructorAsync(int id)
    {
        var instructor = await GetByIdAsync(id);

        if (instructor is null)
            return BaseResponse<string>.ErrorResponse("Instructor not found");

        await DeleteAsync(instructor);
        return BaseResponse<string>.SuccessResponse();
    }


}
