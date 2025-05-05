using Mapster;

namespace CollegeAcadimcManagementSystem.Core.Mapping
{
    public static class MappingConfig
    {
        public static void ConfigMapster(this IServiceCollection services)
        {
            TypeAdapterConfig<Student, StudentDto>.NewConfig()
                .Map(dest => dest.FullName, src => src.FirstName + " " + src.LastName);

            TypeAdapterConfig<Instructor, InstructorDto>.NewConfig()
                .Map(dest => dest.FullName, src => src.FirstName + " " + src.LastName);

            TypeAdapterConfig<Department, DepartmentDto>.NewConfig();
        }
    }
}
