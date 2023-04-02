using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用BCL中的Stack<T>
            Console.WriteLine("----------------使用BCL中的Stack<T>--------------");
            Stack<char> stack = new Stack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c'); // 栈顶数据

            Console.WriteLine("push a, b, c 之后的数据个数为：" + stack.Count);

            char temp = stack.Pop(); // 取得栈顶的数据，并把栈顶的数据删除
            Console.WriteLine("pop 之后得到的数据是：" + temp);
            Console.WriteLine("pop 之后的数据个数为：" + stack.Count);

            char temp2 = stack.Peek(); // 取得栈顶的数据，不删除
            Console.WriteLine("peek 之后得到的数据是：" + temp2);
            Console.WriteLine("peek 之后的数据个数为：" + stack.Count);

            stack.Clear();
            Console.WriteLine("clear 之后的数据个数为：" + stack.Count);

            // Console.WriteLine("空栈的时候取得栈顶的值为：" + stack.Peek()); // 出现异常
            // 当空栈的时候，不要进行peek或者pop操作，否则会出现异常

            // 使用自己的顺序栈
            Console.WriteLine("--------------------使用自定义的顺序栈----------------------");
            IStackDS<char> stackDS = new SeqStack<char>(30);
            stackDS.Push('a');
            stackDS.Push('b');
            stackDS.Push('c'); // 栈顶数据

            Console.WriteLine("push a, b, c 之后的数据个数为：" + stackDS.Count);

            char temp3 = stackDS.Pop(); // 取得栈顶的数据，并把栈顶的数据删除
            Console.WriteLine("pop 之后得到的数据是：" + temp3);
            Console.WriteLine("pop 之后的数据个数为：" + stackDS.Count);

            char temp4 = stackDS.Peek(); // 取得栈顶的数据，不删除
            Console.WriteLine("peek 之后得到的数据是：" + temp4);
            Console.WriteLine("peek 之后的数据个数为：" + stackDS.Count);

            stackDS.Clear();
            Console.WriteLine("clear 之后的数据个数为：" + stackDS.Count);

            // 使用自定义的链栈
            Console.WriteLine("--------------------使用自定义的链栈----------------------");
            IStackDS<char> linkStackDS = new LinkStack<char>();
            linkStackDS.Push('a');
            linkStackDS.Push('b');
            linkStackDS.Push('c'); // 栈顶数据

            Console.WriteLine("push a, b, c 之后的数据个数为：" + linkStackDS.Count);

            char temp5 = linkStackDS.Pop(); // 取得栈顶的数据，并把栈顶的数据删除
            Console.WriteLine("pop 之后得到的数据是：" + temp5);
            Console.WriteLine("pop 之后的数据个数为：" + linkStackDS.Count);

            char temp6 = linkStackDS.Peek(); // 取得栈顶的数据，不删除
            Console.WriteLine("peek 之后得到的数据是：" + temp6);
            Console.WriteLine("peek 之后的数据个数为：" + linkStackDS.Count);

            linkStackDS.Clear();
            Console.WriteLine("clear 之后的数据个数为：" + linkStackDS.Count);

            Console.ReadKey();
        }
    }
}
