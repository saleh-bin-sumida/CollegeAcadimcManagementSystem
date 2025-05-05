namespace CollegeAcadimcManagementSystem.EF.Repositories;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<DepartmentRepository> _logger;

    public DepartmentRepository(AppDbContext context, ILogger<DepartmentRepository> logger) : base(context, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<BaseResponse<PagedResult<DepartmentDto>>> GetPagedDepartments(
        int pageSize,
        int pageNumber,
        string? searchTerm = null)
    {
        Expression<Func<Department, bool>> filter = x => true;

        if (!string.IsNullOrEmpty(searchTerm))
        {
            filter = x => x.Name.Contains(searchTerm) || x.Description.Contains(searchTerm);
        }

        var departments = await GetPagedDataWithSelectionAsync<DepartmentDto>(
            orderBy: x => x.Name,
            criteria: filter,
            pageSize: pageSize,
            pageNumber: pageNumber);

        return BaseResponse<PagedResult<DepartmentDto>>.SuccessResponse("Departments retrieved successfully", departments);
    }

    public async Task<BaseResponse<DepartmentDto>> GetDepartmentById(int id)
    {
        var department = await FindWithSelectionAsync<DepartmentDto>(x => x.Id == id);
        if (department is null)
            return BaseResponse<DepartmentDto>.ErrorResponse("Department not found");

        return BaseResponse<DepartmentDto>.SuccessResponse("Department retrieved successfully", department);
    }

    public async Task<BaseResponse<string>> AddDepartmentAsync(AddDepartmentDto departmentDto)
    {
        var department = departmentDto.Adapt<Department>();
        _context.Add(department);
        _context.SaveChanges();

        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> UpdateDepartmentAsync(int id, UpdateDepartmentDto departmentDto)
    {
        if (id != departmentDto.Id)
            return BaseResponse<string>.ErrorResponse("Department not found");

        var department = await GetByIdAsync(id);

        department.Name = departmentDto.Name;
        department.Description = departmentDto.Description;
        department.ModifiedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return BaseResponse<string>.SuccessResponse();
    }

    public async Task<BaseResponse<string>> DeleteDepartmentAsync(int id)
    {
        var department = await GetByIdAsync(id);

        if (department is null)
            return BaseResponse<string>.ErrorResponse("Department not found");

        await DeleteAsync(department);
        return BaseResponse<string>.SuccessResponse();
    }
}
