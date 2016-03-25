using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(43);
            list.AddLast(4);
            list.AddLast(23);
            list.AddLast(6);
            list.AddLast(7);
            list.AddFirst(8);
            list.AddLast(9);
            list.AddFirst(10);
            list.Print();
            list.Sort();
            list.Print();
            foreach (int value in list)
            {
                Console.WriteLine("From foreach - {0} ", value);
            }
        }
    }
}
