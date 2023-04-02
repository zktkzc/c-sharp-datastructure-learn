using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    internal interface IQueueDS<T>
    {
        int Count { get; }
        int GetLnegth();
        bool IsEmpty();
        void Clear();
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
