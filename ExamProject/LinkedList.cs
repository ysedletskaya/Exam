using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class LinkedList<T> : IPrintable, ILinkedList<T> where T: IComparable<T>
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

        void AddFirst(T value)
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

        void AddLast(T value)
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

        void Remove(T value)
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
                    count--;
                }
                current = current.next;
            }           
        }

        void RemoveFirst()
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

        void RemoveLast()
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

        bool Find(T value)
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

        int Lenght()
        {
            return count;
        }
        
    }
}
