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

            TypeAdapterConfig<StudyLevel, StudyLevelDto>.NewConfig();

            TypeAdapterConfig<StudyLevel, DepartmentStudyLevelDto>.NewConfig()
                .Map(dest => dest.StudyLevelId, src => src.Id)
                .Map(dest => dest.StudyLevelName, src => src.Name);

            TypeAdapterConfig<DepartmentStudyLevelCourse, CourseDto>.NewConfig()
                .Map(dest => dest.Id, src => src.CourseId)
                .Map(dest => dest.Title, src => src.Course.Title);

        }
    }
}
