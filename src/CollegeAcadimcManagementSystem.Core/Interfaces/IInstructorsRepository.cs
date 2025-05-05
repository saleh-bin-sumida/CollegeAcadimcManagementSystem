namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IInstructorsRepository
{
    Task<BaseResponse<PagedResult<InstructorDto>>> GetPagedInstructors(
    int pageSize,
    int pageNumber,
    string searchTerm);

    Task<BaseResponse<InstructorDto>> GetInstructorById(int id);


    Task<BaseResponse<string>> AddInstructorAsync(AddInstructorDto studentDto);


    Task<BaseResponse<string>> UpdateInstructorAsync(int id, UpdateInstructorDto studentDto);



    Task<BaseResponse<string>> DeleteInstructorAsync(int id);
}
