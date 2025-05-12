namespace CollegeAcadimcManagementSystem.EF.Repositories
{
    public class CourseInstructorAssignmentRepository : BaseRepository<CourseInstructorAssignment>, ICourseInstructorAssignmentRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<CourseInstructorAssignmentRepository> _logger;

        public CourseInstructorAssignmentRepository(AppDbContext context, ILogger<CourseInstructorAssignmentRepository> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<BaseResponse<PagedResult<CourseInstructorAssignmentDto>>> GetAllAsync(int pageNumber, int pageSize)
        {
            var query = _context.CourseInstructorAssignments.ProjectToType<CourseInstructorAssignmentDto>();

            var pagedResult = await GetPagedResultAsync(query, pageSize, pageNumber);
            return BaseResponse<PagedResult<CourseInstructorAssignmentDto>>.SuccessResponse("Assignments retrieved successfully", pagedResult);
        }

        public async Task<BaseResponse<CourseInstructorAssignmentDto>> GetByIdAsync(int id)
        {
            var assignment = _context.CourseInstructorAssignments
                .Where(a => a.Id == id).ProjectToType<CourseInstructorAssignmentDto>()
                .FirstOrDefault();

            if (assignment == null)
            {
                return BaseResponse<CourseInstructorAssignmentDto>.ErrorResponse("Assignment not found");
            }

            return BaseResponse<CourseInstructorAssignmentDto>.SuccessResponse("Assignment retrieved successfully", assignment);
        }

        public async Task<BaseResponse<PagedResult<CourseInstructorAssignmentDto>>> GetByInstructorIdAsync(int instructorId, int pageNumber, int pageSize)
        {
            var query = _context.CourseInstructorAssignments
                .Where(a => a.InstructorId == instructorId)
                .ProjectToType<CourseInstructorAssignmentDto>();

            var pagedResult = await GetPagedResultAsync(query, pageSize, pageNumber);
            return BaseResponse<PagedResult<CourseInstructorAssignmentDto>>.SuccessResponse("Assignments retrieved successfully", pagedResult);
        }

        public async Task<BaseResponse<PagedResult<CourseInstructorAssignmentDto>>> GetByOfferedCourseIdAsync(int offeredCourseId, int pageNumber, int pageSize)
        {
            var query = _context.CourseInstructorAssignments
                .Where(a => a.OfferedCourseId == offeredCourseId)
                .ProjectToType<CourseInstructorAssignmentDto>();

            var pagedResult = await GetPagedResultAsync(query, pageSize, pageNumber);
            return BaseResponse<PagedResult<CourseInstructorAssignmentDto>>.SuccessResponse("Assignments retrieved successfully", pagedResult);
        }
    }
}
