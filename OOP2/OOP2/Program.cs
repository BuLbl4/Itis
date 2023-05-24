using OOP2;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

University University = new University();
University.Init();
bool exit = false;

Console.WriteLine("Здравствуйте, напишите свой номер заявления");
var q = int.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Напишите ФИО ");
string w = Console.ReadLine();
Console.Clear();

Console.WriteLine("Напишите дату рождения");
string e = Console.ReadLine();
Console.Clear();


while (!exit)
{

    Console.WriteLine("1. Открыть Список студентов ");
    Console.WriteLine("2. Открыть Список курсов");
    Console.WriteLine("3. Получаемую Квалификационную степень");
    Console.WriteLine("4. Выберите степень курс ");
    Console.WriteLine("5. Выход");
    Console.WriteLine("6. Правила");




    var k = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (k)
    {
        case 1:
            {
                Console.WriteLine($"Студент - {w} \nдата рождения - {e} \nномер заявления {q}");
                break;
            }
        case 2:
            {
                University.PrintCourses();
                break;
            }
        
        case 3:
            {
                University.PrintDegrees();
                break;
            }
        case 4:
            {
                
                Console.WriteLine($"Студент - {w} \nдата рождения - {e} \nномер заявления {q}");

                Console.WriteLine();

                University.PrintDegrees();
                Console.WriteLine();

                Console.WriteLine("Введите шифр степени");
                var cId = int.Parse(Console.ReadLine());

                if (!University.ExistDegree(cId))
                    break;

                Console.WriteLine();

                University.PrintCourses();

                Console.WriteLine("Введите номер курса");
                var pId = int.Parse(Console.ReadLine());
                if (!University.ExistCourse(pId))
                    break;
                
            
                University.AddNewCurriculum(pId, cId);
                break;
            }
        case 5:
            {

                exit = true;
                break;
            }
        case 6:
            {
                Console.WriteLine("Rules");
                var cId = int.Parse(Console.ReadLine());
                var pId = int.Parse(Console.ReadLine());


                break;

            }

        default:
            break;


    }
}