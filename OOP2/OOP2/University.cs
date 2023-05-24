using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class University
    {

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Degree> Degrees { get; set; } = new List<Degree>();
        public List<Course> Courses { get; set; } = new List<Course>();

        public List<Curriculum> Curriculums { get; set; } = new List<Curriculum>();





        public void Init()
        {
            Courses.Clear();
            Courses.Add(new Course()
            {
                codecourse = 1,
                Titles = "Логика и теория алгоритмов",
                IsSpecial = false,
                LectureHours = 100,
                PracticeHours = 100,
                HasExam = true,
                HasCoursePaper = true,
                Prerequisities = "#1"
            }) ;
            Courses.Add(new Course()
            {
                codecourse = 2,
                Titles = "Программирование",
                IsSpecial = false,
                LectureHours = 1000,
                PracticeHours = 1000,
                HasExam = true,
                HasCoursePaper = true,
                Prerequisities = "#2"

            });

            Courses.Add(new Course()
            {
                codecourse = 3,
                Titles = "Чтения",
                IsSpecial = false,
                LectureHours = 1000,
                PracticeHours = 1000,
                HasExam = true,
                HasCoursePaper = true,
                Prerequisities = "#3"

            });
            Courses.Add(new Course()
            {
                codecourse = 4,
                Titles = "Спорт",
                LectureHours = 0,
                PracticeHours = 1200,
                HasExam = true,
                HasCoursePaper = false,
                Prerequisities = "#4"
            });
            Courses.Add(new Course()
            {
                codecourse = 5,
                Titles = "Дискретная Математика",
                LectureHours = 300,
                PracticeHours = 400,
                HasExam = true,
                HasCoursePaper = false,

                Prerequisities = "#5"
            });
            Courses.Add(new Course()
            {
                codecourse = 6,
                Titles = "Математика",
                LectureHours = 400,
                PracticeHours = 500,
                HasExam = true,
                HasCoursePaper = false,
                Prerequisities = "#5"
            });
            Degrees.Add(new Degree()
            {
                codedegr = 1,
                Title = "Бакалавриат",
                CreditsRequired = 70,
                SpecialCoursesRequired = 2
            });
            Degrees.Add(new Degree()
            {
                codedegr = 2,
                Title = "Магистратура",
                CreditsRequired = 70,
                SpecialCoursesRequired = 1
            });
            Degrees.Add(new Degree()
            {
                codedegr = 3,
                Title = "Аспирантура",
                CreditsRequired = 70,
                SpecialCoursesRequired = 1
            });


            //Students.Add(new Student()
            //{
            //    ApplicationNumber = 1,
            //    FullName = "Зубенко Михаил Петрович",
            //    BirthDate = "21.06.11"
            //});


        }

        public void PrintStudents()
        {

            Console.WriteLine("Список студентов;");
            foreach (var prod in Students)
            {
                Console.WriteLine(prod);
            }
        }
        public void PrintDegrees()
        {
            Console.WriteLine("Список квалификаций;");
            foreach (var cust in Degrees)
            {
                Console.WriteLine(cust);
            }
        }
        public void PrintCourses()
        {
            Console.WriteLine("Список курсов;");
            foreach (var ord in Courses)
            {
                Console.WriteLine(ord);
            }
        }



        public bool ExistStudent(int id)
        {
            foreach (var c in Students)
            {
                if (c.ApplicationNumber == id)
                    return true;
            }
            return false;
        }
        public bool ExistDegree(int id)
        {
            foreach (var c in Degrees)
            {
                if (c.codedegr == id)
                    return true;
            }
            return false;
        }

        public bool ExistCourse(int id)
        {
            foreach (var p in Courses)
            {
                if (p.codecourse == id)
                    return true;
            }
            return false;
        }
        public void AddNewCurriculum(int courseId, int degrId)
        {
            Course course = null;
            Course course1 = null;

            Degree degr = null;
            foreach (var c in Courses)
            {
                if (c.codecourse == courseId)
                    course = c;
            }


            foreach (var p in Degrees)
            {
                if (p.codedegr == degrId)
                    degr = p;
            }
            double cr = (course.LectureHours + 1.25 * course.PracticeHours) / 18;
            if (cr < 70)
            {

                Console.WriteLine("не хватает кредитных единиц на требуемый уровень образовния, добавьте курс");
                Console.WriteLine("введите номер курса");
                int courseId1 = int.Parse(Console.ReadLine());
                foreach (var c1 in Courses)
                {
                    if (c1.codecourse == courseId1)
                        course1 = c1;
                }
                double cr1 = (course1.LectureHours + 1.25 * course1.PracticeHours) / 18;
                cr = cr + cr1;
                var ord = new Curriculum(course, course1, degr, cr);
                Console.WriteLine("Добавлено заявление:");
                Console.WriteLine(ord);

            }
            else
            {
                var ord = new Curriculum(course, degr,  cr);
                Console.WriteLine("Добавлено заявление:");
                Console.WriteLine(ord);
            }

        }
    }
}
