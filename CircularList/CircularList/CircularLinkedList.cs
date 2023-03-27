using System.Text;

namespace CircularList
{
    public class CircularLinkedList<T> where T : IComparable
    {
        
        public class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node<T> prev;
            public Node<T> last;

            public Node(T data)
            {
                this.data = data;
            }
        }
        public Node<T> head;
        private int count;
        private int val = 0;

       

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                newNode.prev = head.prev;
                head.prev = newNode;
                head = newNode;
            }
            while (newNode.next != null)
            {
                newNode = newNode.next;
            }
            newNode.last = head;

            count++;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                AddFirst(data);
                return;
            }
            
            var curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = new Node<T>(data);
            curr.next.next = head.last;
            head.last = head;
            curr = head.prev;
            count++;
        }


        public void ElemK(int k)
        {
            if (head == null)
                return;
            var al = head;
            if (k == 0)
            {
                al = al.next;
                Console.WriteLine(al.data);
                return;
            }
            var el = head;
            Node<T> prevel = null;
            while (el != null)
            {
                if (val == k)
                {
                    Console.WriteLine(prevel.data);
                }
                val++;
                prevel = el;
                el = el.next;

            }
        }
        public bool Contains(int k)
        {
            if (head == null)
                return false;
            else
            {
                var current = head;
                while (current != null)
                {
                    if (current.data.CompareTo(k) == 0)
                    {
                        return true;
                    }
                    current = current.next;
                }
            }
            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = head;
            while (el != null)
            {
                sb.Append($"{el.data.ToString()} ->  ");
                el = el.next;
            }
            return sb.ToString();
        }
    }
}