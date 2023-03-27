using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList
{

    public class Elem<T>
    {
        public T Info { get; set; }
        public Elem<T> Next { get; set; }
        public Elem<T> Last { get; set; }   
        public Elem<T> Previous { get; set; }
        public Elem(T Info)
        {
            this.Info = Info;
        }
    }
    public class CircularList<T> where T:IComparable
    {
        public Elem<T> head { get; set; }
        private int val = 0;
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public void AddFirst(T info)
        {
            var el = new Elem<T>(info);
            if (head == null)
            {
                head = el;
            }
            else
            {
                el.Next = head;
                head = el;
            }
            count++;
        }


        public void AddLast(T Info)
        {
            if (head == null)
            {
                AddFirst(Info);
                return;
            }
            var curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = new Elem<T>(Info);
            count++;
        }
        public void DeleteFirst()
        {
            if (head == null)
                return;
            head = head.Next;
            count--;
        }
        public void DeleteLast()
        {
            if (head == null)
                return;
            if (head.Next == null)
            {
                DeleteFirst();
                return;
            }
            var el = head;
            while (el.Next.Next != null)
                el = el.Next;
            el.Next = null;
            count--;
        }
        public void ElemK(int k)
        {
            if (head == null)
                return;
            if (k == 0)
            {
                head = head.Next;
                Console.WriteLine(head.Info);
                return;
            }
            var el = head;
            Elem<T> prevel = null;
            while (el != null)
            {
                if (val == k)
                {
                    var n = el.Next;
                    prevel.Next = n;
                    el = prevel;
                    Console.WriteLine(el.Info);
                    break;
                }
                val++;
                prevel = el;
                el = el.Next;
                
            }
        }
        public bool Contains(int k)
        {
            if (head == null)
                return false;
            else
            {
                var current = head;
                while(current != null)
                {
                    if (current.Info.CompareTo(k) == 0)
                    {
                        return true;
                    }
                    current= current.Next;
                }
            }
            return false;
        }

        public void RightShift()
        {
            if (head == null)
                return;
            else
            {
                var elem = head;
               
                while(elem.Next != null)
                {
                    elem = elem.Next;
                }
                AddFirst(elem.Info);
                DeleteLast();
            }

        }
        public void LeftShift()
        {
            if (head == null)
                return;
            else
            {
                AddLast(head.Info);
                DeleteFirst();
            }
        }
      
        public T[] ToArray()
        {
            if (head == null)
                throw new NullReferenceException("List is empty"); 
            T[] s = new T[count];
            int i = 0;
            while (head! != null)
            {
                s[i] = head.Info;
                head = head.Next;
                i++;
            }
            return s;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = head;
            while (el != null)
            {
                sb.Append($"{el.Info.ToString()} ->  ");
                el = el.Next;
            }
            return sb.ToString();
        }
    }
}
