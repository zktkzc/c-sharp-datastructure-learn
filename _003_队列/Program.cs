using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------使用BCL中的队列-------------------");
            Queue<int> queue = new Queue<int>();

            // 入队
            queue.Enqueue(23); // 队首
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);

            Console.WriteLine("添加元素之后队列的大小为：" + queue.Count);

            // 出队(取得队首的数据并删除)
            int i = queue.Dequeue();
            Console.WriteLine("取得队首的数据为：" + i);
            Console.WriteLine("出队之后队列的大小为：" + queue.Count);

            int j = queue.Peek(); // 取得队首的数据，但不删除
            Console.WriteLine("Peek 得到数据为：" + j);
            Console.WriteLine("Peek 之后队列的大小为：" + queue.Count);

            queue.Clear(); // 清空元素
            Console.WriteLine("Clear 之后队列的大小为：" + queue.Count);

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("--------------------使用自定义的顺序队列-------------------");
            SeqQueue<int> seqQueue = new SeqQueue<int>();

            // 入队
            seqQueue.Enqueue(23); // 队首
            seqQueue.Enqueue(45);
            seqQueue.Enqueue(67);
            seqQueue.Enqueue(89);

            Console.WriteLine("添加元素之后队列的大小为：" + seqQueue.Count);

            // 出队(取得队首的数据并删除)
            int i1 = seqQueue.Dequeue();
            Console.WriteLine("取得队首的数据为：" + i1);
            Console.WriteLine("出队之后队列的大小为：" + seqQueue.Count);

            int j1 = seqQueue.Peek(); // 取得队首的数据，但不删除
            Console.WriteLine("Peek 得到数据为：" + j1);
            Console.WriteLine("Peek 之后队列的大小为：" + seqQueue.Count);

            seqQueue.Clear(); // 清空元素
            Console.WriteLine("Clear 之后队列的大小为：" + seqQueue.Count);

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("--------------------使用自定义的链式队列-------------------");
            LinkQueue<int> linkQueue = new LinkQueue<int>();

            // 入队
            linkQueue.Enqueue(23); // 队首
            linkQueue.Enqueue(45);
            linkQueue.Enqueue(67);
            linkQueue.Enqueue(89);

            Console.WriteLine("添加元素之后队列的大小为：" + linkQueue.Count);

            // 出队(取得队首的数据并删除)
            int i2 = linkQueue.Dequeue();
            Console.WriteLine("取得队首的数据为：" + i2);
            Console.WriteLine("出队之后队列的大小为：" + linkQueue.Count);

            int j2 = linkQueue.Peek(); // 取得队首的数据，但不删除
            Console.WriteLine("Peek 得到数据为：" + j2);
            Console.WriteLine("Peek 之后队列的大小为：" + linkQueue.Count);

            linkQueue.Clear(); // 清空元素
            Console.WriteLine("Clear 之后队列的大小为：" + linkQueue.Count);

            Console.WriteLine("--------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
