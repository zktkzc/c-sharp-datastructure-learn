using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    internal class LinkQueue<T> : IQueueDS<T>
    {
        private Node<T> front; // 头节点
        private Node<T> rear; // 尾节点
        private int count;

        public LinkQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("队列为空，无法出队！");
                return default(T);
            }
            else if (count == 1)
            {
                T temp = front.Data;
                front = null;
                rear = null;
                count = 0;
                return temp;
            }
            else
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;
            }
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (count == 0)
            {
                front = newNode;
                rear = newNode;
                count = 1;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                count++;
            }
        }

        public int GetLnegth()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            if (front != null)
            {
                return front.Data;
            }
            else
            {
                return default(T);
            }
        }
    }
}
