using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    /// <summary>
    /// 单链表的节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Node<T>
    {
        private T data; // 存储数据
        private Node<T> next; // 指针，用来指向下一个元素

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T value)
        {
            this.data = value;
            next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.data = value;
            this.next = next;
        }

        public Node(Node<T> next)
        {
            this.next = next;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
