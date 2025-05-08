namespace CollegeAcadimcManagementSystem.Core.Interfaces;

public interface IStudyLevelRepository : IBaseRepository<StudyLevel>
{
    Task<BaseResponse<PagedResult<StudyLevelDto>>> GetPagedStudyLevels(int pageSize, int pageNumber, string? searchTerm = null);
    Task<BaseResponse<StudyLevelDto>> GetStudyLevelById(int id);
    Task<BaseResponse<string>> AddStudyLevelAsync(AddStudyLevelDto studyLevelDto);
    Task<BaseResponse<string>> UpdateStudyLevelAsync(int id, UpdateStudyLevelDto studyLevelDto);
    Task<BaseResponse<string>> DeleteStudyLevelAsync(int id);
}
