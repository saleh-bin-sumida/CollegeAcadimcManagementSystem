namespace CollegeAcadimcManagementSystem.API.Helper;
public static class SystemApiRouts
{
    public static class Students
    {
        public const string Base = "api/v1/Students";
        public const string GetById = Base + "/{id}";
        public const string GetAll = Base;
        public const string GetByDepartment = Base + "/byDepartment/{departmentId}";
        public const string GetByDepStudyLevel = Base + "/byDepStudyLevel/{depStudyLevelId}";
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
    }

    public static class Instructors
    {
        public const string Base = "api/v1/instructors";
        public const string GetById = Base + "/{id}";
        public const string GetAll = Base;
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
    }

    public static class Departments
    {
        public const string Base = "api/v1/departments";
        public const string GetById = Base + "/{id}";
        public const string GetAll = Base;
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
        public const string AddStudyLevel = Base + "/add-study-level";
    }

    public static class StudyLevels
    {
        public const string Base = "api/v1/studylevels";
        public const string GetById = Base + "/{id}";
        public const string GetAll = Base;
        public const string GetByDepartment = Base + "/byDepartment/{departmentId}";
        public const string GetByCourse = Base + "/byCourse/{courseId}";
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
    }

    public static class Courses
    {
        public const string Base = "api/v1/courses";
        public const string GetAll = Base;
        public const string GetByDepartment = Base + "/byDepartment/{departmentId}";
        public const string GetAllByDepStudyLevel = Base + "/byDepStudyLevel/{depStudyLevelId}";
        public const string GetById = Base + "/{id}";
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
        public const string GetAllByInstrucotr = Base + "byInstrucotr/{instructorId}";
    }

    public static class DepartmentStudyLevels
    {
        public const string Base = "api/v1/departmentstudylevels";
        public const string GetAll = Base;
        public const string GetByCourse = Base + "/byCourse/{courseId}";
        public const string GetByStudyLevel = Base + "/byStudyLevel/{studyLevelId}";
        public const string GetByDepartment = Base + "/byDepartment/{departmentId}";
    }

    public static class StudentEnrollments
    {
        public const string Base = "api/v1/studentenrollments";
        public const string GetByStudent = Base + "/byStudent/{studentId}";
        public const string GetByDepStudyLevel = Base + "/byDepStudyLevel/{depStudyLevelId}";
        public const string GetByOfferedCourse = Base + "/byOfferedCourse/{offeredCourseId}";
    }

    public static class CourseInstructorAssignments
    {
        public const string Base = "api/v1/courseinstructorassignments";
        public const string GetAll = Base;
        public const string GetById = Base + "/{id}";
        public const string GetbyInstructor = Base + "/byInstructor/{instructorId}";
        public const string GetbyOfferedCourse = Base + "/byOfferedCourse/{offeredCourseId}";
    }
}