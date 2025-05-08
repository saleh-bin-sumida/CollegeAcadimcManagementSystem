namespace CollegeAcadimcManagementSystem.API.Controllers;

[ApiController]
public class StudentsController(IUnitOfWork _unitOfWork, ILogger<StudentsController> _logger) : ControllerBase
{


    #region Get Methods

    [HttpGet(SystemApiRouts.Students.GetAll)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudentDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllStudents(
        int pageSize = 10,
        int pageNumber = 1,
        string? searchTerm = null)
    {
        var response = await _unitOfWork.Students.GetPagedStudents(pageSize, pageNumber, searchTerm);
        return Ok(response);
    }



    [HttpGet(SystemApiRouts.Students.GetByDepartment)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudentDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStudentsByDepartment(
      int departmentId,
      int pageSize = 10,
      int pageNumber = 1,
      string? searchTerm = null)
    {
        var response = await _unitOfWork.Students
            .GetStudentsByDepartment(departmentId, pageSize, pageNumber, searchTerm);
        return Ok(response);
    }



    [HttpGet(SystemApiRouts.Students.GetByDepStudyLevel)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudentDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStudentsByDepStudyLevel(
        int depStudyLevelId,
        int pageSize = 10,
        int pageNumber = 1,
        string? searchTerm = null)
    {
        var response = await _unitOfWork.Students
            .GetStudentsByDepartmentStudyLevel(depStudyLevelId, pageSize, pageNumber, searchTerm);
        return Ok(response);
    }


    [HttpGet(SystemApiRouts.Students.GetByCourse)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudentDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStudentsByCourse(
      int courseId,
      int pageSize = 10,
      int pageNumber = 1,
      string? searchTerm = null)
    {
        var response = await _unitOfWork.Students
            .GetStudentsByCourse(courseId, pageSize, pageNumber, searchTerm);
        return Ok(response);
    }


    [HttpGet(SystemApiRouts.Students.GetByInstructor)]
    [ProducesResponseType(typeof(BaseResponse<PagedResult<StudentDto>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStudentsByInstructor(
      int instructorId,
      int pageSize = 10,
      int pageNumber = 1,
      string? searchTerm = null)
    {
        var response = await _unitOfWork.Students
            .GetStudentsByInstructor(instructorId, pageSize, pageNumber, searchTerm);
        return Ok(response);
    }



    [HttpGet(SystemApiRouts.Students.GetById)]
    [ProducesResponseType(typeof(BaseResponse<StudentDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<StudentDto>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetStudentById(int id)
    {
        var response = await _unitOfWork.Students.GetStudentById(id);
        if (!response.Success)
        {
            _logger.LogWarning("Student with ID: {Id} not found", id);
            return BadRequest(response);
        }
        return Ok(response);
    }


    [HttpPost(SystemApiRouts.Students.Add)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateStudent(AddStudentDto studentDto)
    {
        var response = await _unitOfWork.Students.AddStudentAsync(studentDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to create student: {Errors}", response.Errors);
            return BadRequest(response);
        }
        return Ok(response);

    }

    #endregion


    #region Put Methods

    [HttpPut(SystemApiRouts.Students.Update)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateStudent(int id, UpdateStudentDto studentDto)
    {
        var response = await _unitOfWork.Students.UpdateStudentAsync(id, studentDto);
        if (!response.Success)
        {
            _logger.LogError("Failed to update student with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion


    #region Delete Methods

    [HttpDelete(SystemApiRouts.Students.Delete)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<string>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var response = await _unitOfWork.Students.DeleteStudentAsync(id);
        if (!response.Success)
        {
            _logger.LogError("Failed to delete student with ID: {Id}", id);
            return BadRequest(response);
        }
        return Ok(response);
    }

    #endregion
}
