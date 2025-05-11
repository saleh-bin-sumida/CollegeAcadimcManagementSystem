namespace CollegeAcadimcManagementSystem.API.Controllers;

[ApiController]
public class StudyLevelsController(IUnitOfWork _unitOfWork, ILogger<StudyLevelsController> _logger) : ControllerBase
{
    #region Get Methods

    [HttpGet(SystemApiRouts.StudyLevels.GetAll)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudyLevelDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPagedStudyLevels(
        int pageSize = 10,
        int pageNumber = 1,
        string? searchTerm = null)
    {
        var response = await _unitOfWork.StudyLevels.GetPagedStudyLevels(pageSize, pageNumber, searchTerm);
        return Ok(response);
    }

    [HttpGet(SystemApiRouts.StudyLevels.GetByDepartment)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudyLevelDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStudyLevelsByDepartment(int departmentId)
    {
        var response = await _unitOfWork.StudyLevels.GetStudyLevelsByDepartmentAsync(departmentId);
        return Ok(response);
    }


    [HttpGet(SystemApiRouts.StudyLevels.GetByCourse)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudyLevelDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStudyLevelsByCourse(int courseId)
    {
        var response = await _unitOfWork.StudyLevels.GetStudyLevelsByCourseAsync(courseId);
        return Ok(response);
    }



    [HttpGet(SystemApiRouts.StudyLevels.GetById)]
    [ProducesResponseType(typeof(BaseResponse<StudyLevelDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<StudyLevelDto>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetStudyLevelById(int id)
    {
        var response = await _unitOfWork.StudyLevels.GetStudyLevelById(id);
        if (!response.Success)
        {
            _logger.LogWarning("Study level with ID: {Id} not found", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Post Methods

    [HttpPost(SystemApiRouts.StudyLevels.Add)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddStudyLevel(AddStudyLevelDto studyLevelDto)
    {
        var response = await _unitOfWork.StudyLevels.AddStudyLevelAsync(studyLevelDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to create study level: {Errors}", response.Errors);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Put Methods

    [HttpPut(SystemApiRouts.StudyLevels.Update)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateStudyLevel(int id, UpdateStudyLevelDto studyLevelDto)
    {
        var response = await _unitOfWork.StudyLevels.UpdateStudyLevelAsync(id, studyLevelDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to update study level with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Delete Methods

    [HttpDelete(SystemApiRouts.StudyLevels.Delete)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteStudyLevel(int id)
    {
        var response = await _unitOfWork.StudyLevels.DeleteStudyLevelAsync(id);
        if (!response.Success)
        {
            _logger.LogError("Failed to delete study level with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion
}
