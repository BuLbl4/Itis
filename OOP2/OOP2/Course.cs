using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2
{
    public class Course
    {
        public int codecourse { get; set; }  //регистрационный код
        public string Titles { get; set; }  // наименование 
       
        public bool IsSpecial { get; set; }  // false общеобразовательный , true спецкурс

        public  int LectureHours { get; set; } // часы лекций

        public  int PracticeHours { get;set; }  // часы практик

        public bool HasExam { get; set; }  // наличие экзамена  1балл

        public bool HasCoursePaper { get; set; } // наличие курсовой  2балла

        public string Prerequisities { get; set; } //список регистрационных  кодов  курсов,  которые  должны  быть обязательно выбраны вместе с данным курсом






        public override string ToString()
        {
            return $"Курс -  Код {codecourse} , Название {Titles} , спецкурс {IsSpecial} \nкол-во лекций {LectureHours} , кол-во практик {PracticeHours} , наличие экзамена {HasExam} , наличие курсовой {HasCoursePaper} \nСписок кодов    {Prerequisities} \nтрудоемкость {(LectureHours + PracticeHours * 1.25) / 18}";
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
