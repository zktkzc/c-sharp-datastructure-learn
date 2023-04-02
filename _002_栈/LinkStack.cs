using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    internal class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top; // 栈顶元素节点
        private int count = 0; // 栈中元素的个数

        /// <summary>
        /// 取得栈中元素的个数
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// 清空栈中所有的数据
        /// </summary>
        public void Clear()
        {
            count = 0;
            top = null;
        }

        /// <summary>
        /// 取得栈中元素的个数
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return count;
        }

        /// <summary>
        /// 判断栈中是否有数据
        /// </summary>
        /// <returns>栈中是否有数据</returns>
        public bool IsEmpty()
        {
            return count == 0;
        }

        /// <summary>
        /// 取得栈顶元素，不删除
        /// </summary>
        /// <returns>栈顶元素</returns>
        public T Peek()
        {
            return top.Data;
        }

        /// <summary>
        /// 出栈 取得栈顶元素并删除
        /// </summary>
        /// <returns>出栈的元素（栈顶元素）</returns>
        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item">入栈的元素</param>
        public void Push(T item)
        {
            // 把新添加的元素作为栈顶元素节点
            Node<T> newNdoe = new Node<T>(item);
            newNdoe.Next = top;
            top = newNdoe;
            count++;
        }
    }
}
