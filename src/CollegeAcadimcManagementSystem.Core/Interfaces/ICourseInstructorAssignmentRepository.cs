namespace CollegeAcadimcManagementSystem.Core.Interfaces
{
    public interface ICourseInstructorAssignmentRepository : IBaseRepository<CourseInstructorAssignment>
    {
        Task<BaseResponse<PagedResult<CourseInstructorAssignmentDto>>> GetAllAsync(int pageNumber, int pageSize);
        Task<BaseResponse<CourseInstructorAssignmentDto>> GetByIdAsync(int id);
        Task<BaseResponse<PagedResult<CourseInstructorAssignmentDto>>> GetByInstructorIdAsync(int instructorId, int pageNumber, int pageSize);
        Task<BaseResponse<PagedResult<CourseInstructorAssignmentDto>>> GetByOfferedCourseIdAsync(int offeredCourseId, int pageNumber, int pageSize);
    }
}
