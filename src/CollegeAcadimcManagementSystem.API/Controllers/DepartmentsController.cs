namespace CollegeAcadimcManagementSystem.API.Controllers;

[ApiController]
public class DepartmentsController(IUnitOfWork _unitOfWork, ILogger<DepartmentsController> _logger) : ControllerBase
{
    #region Get Methods

    [HttpGet(SystemApiRouts.Departments.GetAll)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<DepartmentDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllDepartments(
        int pageSize = 10,
        int pageNumber = 1,
        string? searchTerm = null)
    {
        var response = await _unitOfWork.Departments.GetPagedDepartments(pageSize, pageNumber, searchTerm);
        return Ok(response);
    }

    [HttpGet(SystemApiRouts.Departments.GetById)]
    [ProducesResponseType(typeof(BaseResponse<DepartmentDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<DepartmentDto>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetDepartmentById(int id)
    {
        var response = await _unitOfWork.Departments.GetDepartmentById(id);
        if (!response.Success)
        {
            _logger.LogWarning("Department with ID: {Id} not found", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    [HttpGet(SystemApiRouts.Departments.GetStudyLevels)]
    [ProducesResponseType(typeof(BaseResponse<List<DepartmentStudyLevelDto>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<List<DepartmentStudyLevelDto>>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetDepartmentStudyLevels(int id)
    {
        var response = await _unitOfWork.Departments.GetStudyLevelsInDepartmentAsync(id);
        if (!response.Success)
        {
            _logger.LogWarning("Failed to retrieve study levels for department ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Post Methods

    [HttpPost(SystemApiRouts.Departments.Add)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateDepartment(AddDepartmentDto departmentDto)
    {
        var response = await _unitOfWork.Departments.AddDepartmentAsync(departmentDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to create department: {Errors}", response.Errors);
            return BadRequest(response);
        }
        return Ok(response);
    }

    [HttpPost(SystemApiRouts.Departments.AddStudyLevel)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddStudyLevelToDepartment(AddStudyLevelToDepartmentDto dto)
    {
        var response = await _unitOfWork.Departments.AddStudyLevelToDepartmentAsync(dto.DepartmentId, dto.StudyLevelId);
        if (!response.Success)
        {
            _logger.LogError("Failed to add study level to department: {Errors}", response.Errors);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Put Methods

    [HttpPut(SystemApiRouts.Departments.Update)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateDepartment(int id, UpdateDepartmentDto departmentDto)
    {
        var response = await _unitOfWork.Departments.UpdateDepartmentAsync(id, departmentDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to update department with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Delete Methods

    [HttpDelete(SystemApiRouts.Departments.Delete)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteDepartment(int id)
    {
        var response = await _unitOfWork.Departments.DeleteDepartmentAsync(id);
        if (!response.Success)
        {
            _logger.LogError("Failed to delete department with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion
}
