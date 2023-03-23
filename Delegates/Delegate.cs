using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Delegate<T>
    {
        public new List<T> list;
        public Delegate(List<T> list)
        {
            this.list= list;
        }


        public int Count(Func<T,bool> func)
        {
            //return list.Count(func);
            int count = 0;  
            foreach (var item in list)
            {
                if(func(item)) 
                    count++;
            }
            Console.WriteLine(count);
            return count;
        }
        public T1? Aggregate1<T1>(Func<T,T1?,T1> func) 
        {
            var temp = default(T1);
            foreach(var item in list)
            {
                temp = func(item,temp);
            }
            Console.WriteLine(temp);
            return temp;
        }
        public T1? Aggregate2<T1>(Func<T,T1,T1> func, T1 defval)
        {
            foreach (var item in list) 
            {
                defval = func(item,defval);
            }
            Console.WriteLine(defval);
            return defval;
        }
        public override string ToString()
        {
            foreach (var i in list)
                Console.Write($"{i} ");
            return "";
        }



    }
}
