﻿namespace CollegeAcadimcManagementSystem.EF.Data.Seading;

public static class SeedData
{
    public static List<Student> SeedStudents()
    {
        return new List<Student>
        {
            new Student
            {
                Id = 1,
                LastName = "محمد",
                FirstName = "أحمد محمد",
                Email = "ahmed@example.com",
                PhoneNumber = "1121456789",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 2,
                FirstName = "سارة ",
                LastName = "سارة علي",
                Email = "sara@example.com",
                PhoneNumber = "2927654321",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 3,
                FirstName = "محمد حسن",
                LastName = "محمد حسن",
                Email = "mohamed@example.com",
                PhoneNumber = "31128833445",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 4,
                FirstName = "ليلى إبراهيم",
                LastName = "ليلى إبراهيم",
                Email = "leila@example.com",
                PhoneNumber = "4243344556",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 5,
                FirstName = "علي يوسف",
                LastName = "علي يوسف",
                Email = "ali@example.com",
                PhoneNumber = "0344455667",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 6,
                FirstName = "فاطمة سعيد",
                LastName = "فاطمة سعيد",
                Email = "fatima@example.com",
                PhoneNumber = "5445566778",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 7,
                FirstName = "خالد عبد الله",
                LastName = "خالد عبد الله",
                Email = "khaled@example.com",
                PhoneNumber = "6556677889",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 8,
                FirstName = "مريم أحمد",
                LastName = "مريم أحمد",
                Email = "mariam@example.com",
                PhoneNumber = "7667788990",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 9,
                FirstName = "يوسف علي",
                LastName = "يوسف علي",
                Email = "youssef@example.com",
                PhoneNumber = "0878899001",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 10,
                FirstName = "نورا محمد",
                LastName = "نورا محمد",
                Email = "nora@example.com",
                PhoneNumber = "9889900112",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 11,
                FirstName = "حسن علي",
                LastName = "حسن علي",
                Email = "hassan@example.com",
                PhoneNumber = "14490011223",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 12,
                FirstName = "منى سعيد",
                LastName = "منى سعيد",
                Email = "mona@example.com",
                PhoneNumber = "01022122334",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 13,
                FirstName = "عمر خالد",
                LastName = "عمر خالد",
                Email = "omar@example.com",
                PhoneNumber = "01112233445",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 14,
                FirstName = "هدى إبراهيم",
                LastName = "هدى إبراهيم",
                Email = "huda@example.com",
                PhoneNumber = "2223344556",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 15,
                FirstName = "ياسر يوسف",
                LastName = "ياسر يوسف",
                Email = "yasser@example.com",
                PhoneNumber = "03744455667",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 16,
                FirstName = "نادية سعيد",
                LastName = "نادية سعيد",
                Email = "nadia@example.com",
                PhoneNumber = "0045566778",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 17,
                FirstName = "ماجد عبد الله",
                LastName = "ماجد عبد الله",
                Email = "majed@example.com",
                PhoneNumber = "9956677889",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 18,
                FirstName = "سلمى أحمد",
                LastName = "سلمى أحمد",
                Email = "salma@example.com",
                PhoneNumber = "0667788990",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 19,
                FirstName = "زياد علي",
                LastName = "زياد علي",
                Email = "ziad@example.com",
                PhoneNumber = "0228899001",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Student
            {
                Id = 20,
                FirstName = "نور محمد",
                LastName = "نور محمد",
                Email = "noor@example.com",
                PhoneNumber = "0874900112",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            }
        };
    }

    public static List<Instructor> SeedInstructors()
    {
        return new List<Instructor>
        {
            new Instructor
            {
                Id = 1,
                LastName = "محمد",
                FirstName = "أحمد محمد",
                Email = "ahmed@example.com",
                PhoneNumber = "1121456789",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 2,
                FirstName = "سارة ",
                LastName = "سارة علي",
                Email = "sara@example.com",
                PhoneNumber = "2927654321",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 3,
                FirstName = "محمد حسن",
                LastName = "محمد حسن",
                Email = "mohamed@example.com",
                PhoneNumber = "31128833445",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 4,
                FirstName = "ليلى إبراهيم",
                LastName = "ليلى إبراهيم",
                Email = "leila@example.com",
                PhoneNumber = "4243344556",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 5,
                FirstName = "علي يوسف",
                LastName = "علي يوسف",
                Email = "ali@example.com",
                PhoneNumber = "0344455667",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 6,
                FirstName = "فاطمة سعيد",
                LastName = "فاطمة سعيد",
                Email = "fatima@example.com",
                PhoneNumber = "5445566778",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 7,
                FirstName = "خالد عبد الله",
                LastName = "خالد عبد الله",
                Email = "khaled@example.com",
                PhoneNumber = "6556677889",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 8,
                FirstName = "مريم أحمد",
                LastName = "مريم أحمد",
                Email = "mariam@example.com",
                PhoneNumber = "7667788990",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 9,
                FirstName = "يوسف علي",
                LastName = "يوسف علي",
                Email = "youssef@example.com",
                PhoneNumber = "0878899001",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 10,
                FirstName = "نورا محمد",
                LastName = "نورا محمد",
                Email = "nora@example.com",
                PhoneNumber = "9889900112",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 11,
                FirstName = "حسن علي",
                LastName = "حسن علي",
                Email = "hassan@example.com",
                PhoneNumber = "14490011223",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 12,
                FirstName = "منى سعيد",
                LastName = "منى سعيد",
                Email = "mona@example.com",
                PhoneNumber = "01022122334",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 13,
                FirstName = "عمر خالد",
                LastName = "عمر خالد",
                Email = "omar@example.com",
                PhoneNumber = "01112233445",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 14,
                FirstName = "هدى إبراهيم",
                LastName = "هدى إبراهيم",
                Email = "huda@example.com",
                PhoneNumber = "2223344556",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 15,
                FirstName = "ياسر يوسف",
                LastName = "ياسر يوسف",
                Email = "yasser@example.com",
                PhoneNumber = "03744455667",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 16,
                FirstName = "نادية سعيد",
                LastName = "نادية سعيد",
                Email = "nadia@example.com",
                PhoneNumber = "0045566778",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 17,
                FirstName = "ماجد عبد الله",
                LastName = "ماجد عبد الله",
                Email = "majed@example.com",
                PhoneNumber = "9956677889",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 18,
                FirstName = "سلمى أحمد",
                LastName = "سلمى أحمد",
                Email = "salma@example.com",
                PhoneNumber = "0667788990",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 19,
                FirstName = "زياد علي",
                LastName = "زياد علي",
                Email = "ziad@example.com",
                PhoneNumber = "0228899001",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Instructor
            {
                Id = 20,
                FirstName = "نور محمد",
                LastName = "نور محمد",
                Email = "noor@example.com",
                PhoneNumber = "0874900112",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            }
        };
    }

    public static List<Department> SeedDepartments()
    {
        return new List<Department>
        {
            new Department
            {
                Id = 1,
                Name = "Computer Science",
                Description = "Department of Computer Science",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Department
            {
                Id = 2,
                Name = "Mathematics",
                Description = "Department of Mathematics",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new Department
            {
                Id = 3,
                Name = "Physics",
                Description = "Department of Physics",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            }
        };
    }

    public static List<StudyLevel> SeedStudyLevels()
    {
        return new List<StudyLevel>
        {
            new StudyLevel
            {
                Id = 1,
                Name = "Level 1",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new StudyLevel
            {
                Id = 2,
                Name = "Level 2",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new StudyLevel
            {
                Id = 3,
                Name = "Level 3",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new StudyLevel
            {
                Id = 4,
                Name = "Level 4",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new StudyLevel
            {
                Id = 5,
                Name = "Level 5",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            },
            new StudyLevel
            {
                Id = 6,
                Name = "Level 6",
                CreatedDate = new DateTime(2023, 10, 1),
                IsDeleted = false
            }
        };
    }

    public static List<DepartmentStudyLevel> SeedDepartmentStudyLevels()
    {
        return new List<DepartmentStudyLevel>
        {
            new DepartmentStudyLevel {Id = 1, DepartmentId = 1, StudyLevelId = 1 },
            new DepartmentStudyLevel {Id = 2, DepartmentId = 1, StudyLevelId = 2 },
            new DepartmentStudyLevel {Id = 3, DepartmentId = 1, StudyLevelId = 3 },
            new DepartmentStudyLevel {Id = 4, DepartmentId = 1, StudyLevelId = 4 },
            new DepartmentStudyLevel {Id = 5, DepartmentId = 1, StudyLevelId = 5 },
            new DepartmentStudyLevel {Id = 6, DepartmentId = 1, StudyLevelId = 6 },
            new DepartmentStudyLevel {Id = 7, DepartmentId = 2, StudyLevelId = 1 },
            new DepartmentStudyLevel {Id = 8, DepartmentId = 2, StudyLevelId = 2 },
            new DepartmentStudyLevel {Id = 9, DepartmentId = 2, StudyLevelId = 3 },
            new DepartmentStudyLevel {Id = 10, DepartmentId = 3, StudyLevelId = 4 },
            new DepartmentStudyLevel {Id = 11, DepartmentId = 3, StudyLevelId = 5 },
            new DepartmentStudyLevel {Id = 12, DepartmentId = 3, StudyLevelId = 6 },
        };
    }

    public static List<Course> SeedCourses()
    {
        return new List<Course>
        {
            new Course { Id = 1, Title = "Mathematics 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 2, Title = "Physics 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 3, Title = "Chemistry 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 4, Title = "Biology 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 5, Title = "Computer Science 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 6, Title = "History 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 7, Title = "Philosophy 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 8, Title = "Economics 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 9, Title = "Statistics 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
            new Course { Id = 10, Title = "Literature 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false }
        };
    }

    public static List<DepartmentStudyLevelCourse> SeedDepartmentStudyLevelCourses()
    {
        return new List<DepartmentStudyLevelCourse>
        {
            new DepartmentStudyLevelCourse { Id = 1, CourseId = 1, DepartmentStudyLevelId = 1 },
            new DepartmentStudyLevelCourse { Id = 2, CourseId = 2, DepartmentStudyLevelId = 1 },
            new DepartmentStudyLevelCourse { Id = 3, CourseId = 3, DepartmentStudyLevelId = 2 },
            new DepartmentStudyLevelCourse { Id = 4, CourseId = 4, DepartmentStudyLevelId = 2 },
            new DepartmentStudyLevelCourse { Id = 5, CourseId = 5, DepartmentStudyLevelId = 3 },
            new DepartmentStudyLevelCourse { Id = 6, CourseId = 6, DepartmentStudyLevelId = 3 },
            new DepartmentStudyLevelCourse { Id = 7, CourseId = 7, DepartmentStudyLevelId = 4 },
            new DepartmentStudyLevelCourse { Id = 8, CourseId = 8, DepartmentStudyLevelId = 4 },
            new DepartmentStudyLevelCourse { Id = 9, CourseId = 9, DepartmentStudyLevelId = 5 },
            new DepartmentStudyLevelCourse { Id = 10, CourseId = 10, DepartmentStudyLevelId = 5 }
        };
    }


    public static List<DepStudyLevelCourseInstructor> SeedDepStudyLevelCourseInstructors()
    {
        return new List<DepStudyLevelCourseInstructor>
        {
            new DepStudyLevelCourseInstructor { Id = 1, InstructorId = 1, DepStudyLevelCourseId = 1 },
            new DepStudyLevelCourseInstructor { Id = 2, InstructorId = 2, DepStudyLevelCourseId = 2 },
            new DepStudyLevelCourseInstructor { Id = 3, InstructorId = 3, DepStudyLevelCourseId = 3 },
            new DepStudyLevelCourseInstructor { Id = 4, InstructorId = 4, DepStudyLevelCourseId = 4 },
            new DepStudyLevelCourseInstructor { Id = 5, InstructorId = 5, DepStudyLevelCourseId = 5 },
            new DepStudyLevelCourseInstructor { Id = 6, InstructorId = 6, DepStudyLevelCourseId = 6 },
            new DepStudyLevelCourseInstructor { Id = 7, InstructorId = 7, DepStudyLevelCourseId = 7 },
            new DepStudyLevelCourseInstructor { Id = 8, InstructorId = 8, DepStudyLevelCourseId = 8 },
            new DepStudyLevelCourseInstructor { Id = 9, InstructorId = 9, DepStudyLevelCourseId = 9 },
            new DepStudyLevelCourseInstructor { Id = 10, InstructorId = 10, DepStudyLevelCourseId = 10 },
            new DepStudyLevelCourseInstructor { Id = 11, InstructorId = 11, DepStudyLevelCourseId = 1 },
            new DepStudyLevelCourseInstructor { Id = 12, InstructorId = 12, DepStudyLevelCourseId = 2 },
            new DepStudyLevelCourseInstructor { Id = 13, InstructorId = 13, DepStudyLevelCourseId = 3 },
            new DepStudyLevelCourseInstructor { Id = 14, InstructorId = 14, DepStudyLevelCourseId = 4 },
            new DepStudyLevelCourseInstructor { Id = 15, InstructorId = 15, DepStudyLevelCourseId = 5 },
            new DepStudyLevelCourseInstructor { Id = 16, InstructorId = 16, DepStudyLevelCourseId = 6 },
            new DepStudyLevelCourseInstructor { Id = 17, InstructorId = 17, DepStudyLevelCourseId = 7 },
            new DepStudyLevelCourseInstructor { Id = 18, InstructorId = 18, DepStudyLevelCourseId = 8 },
            new DepStudyLevelCourseInstructor { Id = 19, InstructorId = 19, DepStudyLevelCourseId = 9 },
            new DepStudyLevelCourseInstructor { Id = 20, InstructorId = 20, DepStudyLevelCourseId = 10 }
        };
    }

    public static List<StudentEnrollment> SeedStudentEnrollments()
    {
        return new List<StudentEnrollment>
        {
            new StudentEnrollment { Id = 1, StudentId = 1, DepartmentStudyLevelId = 1 },
            new StudentEnrollment { Id = 2, StudentId = 2, DepartmentStudyLevelId = 2 },
            new StudentEnrollment { Id = 3, StudentId = 3, DepartmentStudyLevelId = 3 },
            new StudentEnrollment { Id = 4, StudentId = 4, DepartmentStudyLevelId = 4 },
            new StudentEnrollment { Id = 5, StudentId = 5, DepartmentStudyLevelId = 5 },
            new StudentEnrollment { Id = 6, StudentId = 6, DepartmentStudyLevelId = 6 },
            new StudentEnrollment { Id = 7, StudentId = 7, DepartmentStudyLevelId = 7 },
            new StudentEnrollment { Id = 8, StudentId = 8, DepartmentStudyLevelId = 8 },
            new StudentEnrollment { Id = 9, StudentId = 9, DepartmentStudyLevelId = 9 },
            new StudentEnrollment { Id = 10, StudentId = 10, DepartmentStudyLevelId = 10 }
        };
    }
}
