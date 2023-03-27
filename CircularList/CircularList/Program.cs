using System.Diagnostics.Tracing;

namespace CircularList
{
    public class Program
    {
        static void Main()
        {
        //    CircularList<int> c = new CircularList<int>();
        //    c.AddFirst(1);
        //    c.AddFirst(2);
        //    c.AddFirst(3);
        //    c.AddFirst(4);
        //    c.AddFirst(5);
        //    c.LeftShift();
        //    Console.WriteLine(c);


           
            //c.LeftShift();
            //int[] c1 = new int[c.Count];
            //c1 = c.ToArray();
            //for (int i = 0; i < c1.Length; i++)
            //{ 
            //    Console.Write($"{c1[i]} -> ");
            //}

            CircularLinkedList<int> c = new CircularLinkedList<int>();
            c.AddFirst(1);
            c.AddFirst(2);
            c.AddFirst(3);
            c.AddLast(4);
            c.ElemK(1);
            Console.WriteLine(c.Contains(3));
            Console.WriteLine(c);
        }

    }
}
