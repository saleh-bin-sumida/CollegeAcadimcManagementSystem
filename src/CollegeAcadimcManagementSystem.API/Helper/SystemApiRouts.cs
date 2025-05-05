namespace CollegeAcadimcManagementSystem.API.Helper;
public static class SystemApiRouts
{
    public static class Students
    {
        public const string Base = "api/v1/Students";
        public const string GetById = Base + "/{id}";
        public const string GetAll = Base;
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
    }
}
