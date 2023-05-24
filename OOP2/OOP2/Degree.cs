using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Degree
    {
        public int codedegr { get; set; } //шифр

        public string Title { get; set; } //наименование

        public int CreditsRequired { get; set; } //общее кол-во кредитных единиц

        public int SpecialCoursesRequired { get; set; }  //минимальное кол-во спецкурсов

        public override string ToString()
        {
            return $"Шифр  {codedegr}  Наименование - {Title} кол-во кредитных единиц - {CreditsRequired}  кол-во спецкурсов - {SpecialCoursesRequired}";
        }

    }
}
