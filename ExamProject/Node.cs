using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class Node<T>
    {
        public T value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Node<T> previous
        {
            get { return this.previous; }
            set { this.previous = value; }
        }

        public Node<T> next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        
        public Node(T value)
        {
            this.value = value;
            this.previous = null;
            this.next = null;
        }    
    }
}
