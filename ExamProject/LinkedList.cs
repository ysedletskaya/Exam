using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class LinkedList<T> : IPrintable, ILinkedList<T> where T: IComparable<T>
    {
        protected Node<T> first;
        protected Node<T> last;
        protected Node<T> current;
        protected int count;

        public LinkedList()
        {
            this.first = this.last = this.current = null;
            this.count = 0;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                newNode.next = first;
                first = newNode;
                newNode.next.previous = first;
            }
            count++;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                last.next = newNode;
                newNode.previous = last;
                last = newNode;
            }
            count++;
        }

        public void Remove(T value)
        {
            current = first;
            while (current != null)
            {
                if (current.value.CompareTo(value) == 0)
                {
                    if (current.next != null)
                    {
                        current.next.previous = current.previous;
                    }
                    else
                    {
                        current.next.previous = null;
                    }
                    if (current.previous != null)
                    {
                        current.previous.next = current.next;
                    }
                    else
                    {
                        current.previous.next = null;
                    }
                    count--;
                }
                current = current.next;
            }           
        }

        public void RemoveFirst()
        {
            if (first == null)
            {
                Console.WriteLine("Nothing to remove - the list is empty");
            }
            else
            {
                if (first.next != null)
                {
                    first.next.previous = null;
                }
                first = first.next;
                count--;
            }
        }

        public void RemoveLast()
        {
            if (last == null)
            {
                Console.WriteLine("Nothing to remove - the list is empty");
            }
            else
            {
                if (last.previous != null)
                {
                    last.previous.next = null;
                }
                last = last.previous;
                count--;
            }        
        }

        public bool Find(T value)
        {
            current = first;
            while (current != null)
            {
                if (current.value.CompareTo(value) == 0)
                {
                    return true;
                }
                current = current.next;
            }
            return false;      
        }

        public int Lenght()
        {
            return count;
        }
        
        public Node<T> First()
        {
            return first;
        }

        public Node<T> Last()
        {
            return last;
        }

        public void Print()
        {
            current = first;
            Console.Write("{");
            while (current != null)
            {
                Console.Write(" {0} ", current.value);
                current = current.next;
            }
            Console.WriteLine("}");
        }
    }
}
