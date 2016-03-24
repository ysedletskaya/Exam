using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public interface ILinkedList
    {
        void AddFirst(int value);
        void AddLast(int value);
        void Remove(int value);
        void RemoveFirst();
        void RemoveLast();
        bool Find(int value);
        int Lenght();
    }
}
