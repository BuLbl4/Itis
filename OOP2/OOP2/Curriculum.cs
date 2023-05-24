using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Curriculum //договор
    {
        public int codecurr { get; set; }  //регистрационный код
        public DateTime CreationDate { get; set; }  //дата составления 
        public DateTime ConfirmationDate { get; set; }  //дата утверждения 
        public Degree Degree { get; set; }
        public Course Course { get; set; }
        public Course Course1 { get; set; }

        public Student Student { get; set; }
        private static int CurId { get; set; } = 0;
        private double cr;

        public Curriculum(Course c, Degree d, double cr)
        {
            Degree = d;
            Course = c;
            this.cr = cr;
        }

        public Curriculum(Course c, Course c1, Degree d, double cr)
        {
            Degree = d;
            Course = c;
            Course1 = c1; ;
            this.cr = cr;
        }

        public override string ToString()
        {
            return $"Заявление {CurId} \n{Course} \n{Course1} \n{Degree} ";
        }

    }
}
