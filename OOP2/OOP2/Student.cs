using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2
{
    public class Student
    {
        public int ApplicationNumber { get; set; }  // номер заявления
        public string FullName { get; set; }  // ФИО
        public string BirthDate { get; set; }  // дата рождения

        public Degree Degree { get; set; }
        public Course Course { get; set; }

        public Student(Course codecourse, Degree codedegr)
        {
            Course = codecourse;
            Degree = codedegr;
        }

        public override string ToString()
        {
            return $"Студент  -  {FullName} номер заявления - {ApplicationNumber} дата рождения - {BirthDate}";
        }
    }
}
