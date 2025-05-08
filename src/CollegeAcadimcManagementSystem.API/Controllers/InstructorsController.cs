namespace CollegeAcadimcManagementSystem.API.Controllers;

[ApiController]
public class InstructorsController(IUnitOfWork _unitOfWork, ILogger<InstructorsController> _logger) : ControllerBase
{
    #region Get Methods

    [HttpGet(SystemApiRouts.Instructors.GetAll)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<InstructorDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllInstructors(
        int pageSize = 10,
        int pageNumber = 1,
        string? searchTerm = null)
    {
        var response = await _unitOfWork.Instructors.GetPagedInstructors(pageSize, pageNumber, searchTerm);
        return Ok(response);
    }



    //[HttpGet(SystemApiRouts.Instructors.GetAll)]
    //[ProducesResponseType(typeof(BaseResponse<PagedResult<InstructorDto>>), StatusCodes.Status200OK)]
    //public async Task<IActionResult> GetAllInstructorsBy(
    //    int pageSize = 10,
    //    int pageNumber = 1,
    //    string? searchTerm = null)
    //{
    //    var response = await _unitOfWork.Instructors.GetPagedInstructors(pageSize, pageNumber, searchTerm);
    //    return Ok(response);
    //}



    [HttpGet(SystemApiRouts.Instructors.GetById)]
    [ProducesResponseType(typeof(BaseResponse<InstructorDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<InstructorDto>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetInstructorById(int id)
    {
        var response = await _unitOfWork.Instructors.GetInstructorById(id);
        if (!response.Success)
        {
            _logger.LogWarning("Instructor with ID: {Id} not found", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Post Methods

    [HttpPost(SystemApiRouts.Instructors.Add)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateInstructor(AddInstructorDto instructorDto)
    {
        var response = await _unitOfWork.Instructors.AddInstructorAsync(instructorDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to create instructor: {Errors}", response.Errors);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Put Methods

    [HttpPut(SystemApiRouts.Instructors.Update)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateInstructor(int id, UpdateInstructorDto instructorDto)
    {
        var response = await _unitOfWork.Instructors.UpdateInstructorAsync(id, instructorDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to update instructor with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion

    #region Delete Methods

    [HttpDelete(SystemApiRouts.Instructors.Delete)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteInstructor(int id)
    {
        var response = await _unitOfWork.Instructors.DeleteInstructorAsync(id);
        if (!response.Success)
        {
            _logger.LogError("Failed to delete instructor with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion
}
