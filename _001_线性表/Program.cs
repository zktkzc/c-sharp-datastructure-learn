using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用BCL中的List线性表
            //List<string> strList = new List<string>();
            //strList.Add("2134");
            //strList.Add("456");
            //strList.Add("789");
            //Console.WriteLine(strList[1]); // 通过所引器访问元素

            //strList.Remove("789"); // 移除指定元素
            //Console.WriteLine(strList.Count); // 通过Count访问List的大小

            //strList.Clear(); // 清空列表
            //Console.WriteLine(strList.Count);
            //Console.ReadKey();

            // 使用自定义的顺序表
            //SeqList<string> seqList = new SeqList<string>();
            //seqList.Add("123");
            //seqList.Add("456");
            //seqList.Add("789");

            //Console.WriteLine(seqList.GetEle(0));
            //Console.WriteLine(seqList[0]);
            //seqList.Insert(1, "777");
            //for (int i = 0; i < seqList.GetLength(); i++)
            //{
            //    Console.Write(seqList[i] + " ");
            //}
            //Console.WriteLine();
            //seqList.Delete(0);
            //for (int i = 0; i < seqList.GetLength(); i++)
            //{
            //    Console.Write(seqList[i] + " ");
            //}
            //Console.WriteLine();
            //seqList.Clear();
            //Console.WriteLine(seqList.GetLength());
            //Console.ReadKey();

            // 使用自定义的单链表
            LinkList<string> linkList = new LinkList<string>();
            linkList.Add("123");
            linkList.Add("456");
            linkList.Add("789");

            Console.WriteLine(linkList.GetEle(0));
            Console.WriteLine(linkList[0]);
            linkList.Insert(1, "777");
            for (int i = 0; i < linkList.GetLength(); i++)
            {
                Console.Write(linkList[i] + " ");
            }
            Console.WriteLine();
            linkList.Delete(0);
            for (int i = 0; i < linkList.GetLength(); i++)
            {
                Console.Write(linkList[i] + " ");
            }
            Console.WriteLine();
            linkList.Clear();
            Console.WriteLine(linkList.GetLength());
            Console.ReadKey();
        }
    }
}
