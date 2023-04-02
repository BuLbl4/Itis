using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestrovka
{
    public class ShellSort
    {
        public List<int[]> list;
        public ShellSort(List<int[]> lists)
        {
            list = lists;
        }
        public void Sort() 
        {
            for(int i = 0; i < list.Count; i++) 
            {
                
            }
        }
        public int[] Shellsort(int[] lists)
        {
            
            int iteration = 0;
            var d = lists.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < lists.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (lists[j - d] > lists[j]))
                    {
                        (lists[j], lists[j - d]) = (lists[j - d], lists[j]);
                        j = j - d;
                        iteration++;
                    }
                }
                d = d / 2;
            }
            Console.WriteLine(iteration);
            return lists;
        }

        public override string ToString()
        {
            for(int i = 0; i < list.Count;i++)
                Console.WriteLine(list[i]);
            return "";
        }
    }
}
