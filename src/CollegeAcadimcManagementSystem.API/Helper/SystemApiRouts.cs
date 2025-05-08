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
        public const string GetByInstructor = Base + "/byInstructor/{InstructorId}";
        public const string GetByCourse = Base + "/byCourse/{courseId}";
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
        public const string GetStudyLevels = Base + "/{id}/study-levels"; // New route
    }

    public static class StudyLevels
    {
        public const string Base = "api/v1/studylevels";
        public const string GetById = Base + "/{id}";
        public const string GetAll = Base;
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
    }

    public static class Courses
    {
        public const string Base = "api/v1/courses";
        public const string GetAll = Base;
        public const string GetAllByDepStudyLevel = Base + "/byDepStudyLevel/{depStudyLevelId}";
        public const string GetById = Base + "/{id}";
        public const string Add = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
        public const string GetAllByInstrucotr = Base + "byInstrucotr/{instructorId}";
    }
}
