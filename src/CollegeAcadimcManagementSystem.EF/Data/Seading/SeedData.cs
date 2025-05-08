namespace CollegeAcadimcManagementSystem.EF.Data.Seading;

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
            new DepartmentStudyLevel { DepartmentId = 1, StudyLevelId = 1 },
            new DepartmentStudyLevel { DepartmentId = 1, StudyLevelId = 2 },
            new DepartmentStudyLevel { DepartmentId = 1, StudyLevelId = 3 },
            new DepartmentStudyLevel { DepartmentId = 1, StudyLevelId = 4 },
            new DepartmentStudyLevel { DepartmentId = 1, StudyLevelId = 5 },
            new DepartmentStudyLevel { DepartmentId = 1, StudyLevelId = 6 },
            new DepartmentStudyLevel { DepartmentId = 2, StudyLevelId = 1 },
            new DepartmentStudyLevel { DepartmentId = 2, StudyLevelId = 2 },
            new DepartmentStudyLevel { DepartmentId = 2, StudyLevelId = 3 },
            new DepartmentStudyLevel { DepartmentId = 3, StudyLevelId = 4 },
            new DepartmentStudyLevel { DepartmentId = 3, StudyLevelId = 5 },
            new DepartmentStudyLevel { DepartmentId = 3, StudyLevelId = 6 },
        };
    }

    //public static List<Course> SeedCourses()
    //{
    //    return new List<Course>
    //    {
    //        new Course { Id = 1, Title = "Mathematics 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false },
    //        new Course { Id = 2, Title = "Physics 101", CreatedDate = new DateTime(2023, 10, 1), IsDeleted = false }
    //    };
    //}

    //public static List<DepartmentStudyLevelCourse> SeedCourseDepartmentStudyLevels()
    //{
    //    return new List<DepartmentStudyLevelCourse>
    //    {
    //        new DepartmentStudyLevelCourse { CourseId = 1,DepartmentStudyLevelId = 1 },
    //        new DepartmentStudyLevelCourse { CourseId = 2,DepartmentStudyLevelId = 1 },
    //        new DepartmentStudyLevelCourse { CourseId = 2, DepartmentStudyLevelId = 2 }
    //    };
    //}
}
