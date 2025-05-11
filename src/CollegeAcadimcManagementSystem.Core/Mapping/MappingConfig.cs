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

            TypeAdapterConfig<DepartmentStudyLevel, DepartmentStudyLevelDto>.NewConfig()
                .Map(dest => dest.DepartmentName, src => src.Department.Name)
                .Map(dest => dest.StudyLevelName, src => src.StudyLevel.Name);

            TypeAdapterConfig<DepartmentStudyLevelCourse, CourseDto>.NewConfig()
                .Map(dest => dest.Id, src => src.CourseId)
                .Map(dest => dest.Title, src => src.Course.Title);


            TypeAdapterConfig<StudentEnrollment, StudentDto>.NewConfig()
                 .Map(dest => dest.Id, src => src.StudentId)
                 .Map(dest => dest.FullName, src => src.Student.FirstName + " " + src.Student.LastName)
                 .Map(dest => dest.Email, src => src.Student.Email)
                 .Map(dest => dest.PhoneNumber, src => src.Student.PhoneNumber);

        }
    }
}
