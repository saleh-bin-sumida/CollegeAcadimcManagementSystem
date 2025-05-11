namespace CollegeAcadimcManagementSystem.API.Controllers;

[ApiController]
[Route(SystemApiRouts.DepartmentStudyLevels.Base)]
public class DepartmentStudyLevelController(IUnitOfWork _unitOfWork) : ControllerBase
{

    [HttpGet(SystemApiRouts.DepartmentStudyLevels.GetAll)]
    public async Task<IActionResult> GetAllDepartmentStudyLevels()
    {
        var response = await _unitOfWork.DepartmentStudyLevels.GetAllDepartmentStudyLevels();
        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

    [HttpGet(SystemApiRouts.DepartmentStudyLevels.GetByCourse)]
    public async Task<IActionResult> GetDepartmentStudyLevelsByCourse(int courseId)
    {
        var response = await _unitOfWork.DepartmentStudyLevels.GetDepartmentStudyLevelsByCourse(courseId);
        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }


    [HttpGet(SystemApiRouts.DepartmentStudyLevels.GetByStudyLevel)]
    public async Task<IActionResult> GetDepartmentStudyLevelsByStudyLevel(int studyLevelId)
    {
        var response = await _unitOfWork.DepartmentStudyLevels.GetDepartmentStudyLevelsByStudyLevel(studyLevelId);
        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

    [HttpGet(SystemApiRouts.DepartmentStudyLevels.GetByDepartment)]
    public async Task<IActionResult> GetDepartmentStudyLevelsByDepartment(int departmentId)
    {
        var response = await _unitOfWork.DepartmentStudyLevels.GetDepartmentStudyLevelsByDepartment(departmentId);
        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

}
