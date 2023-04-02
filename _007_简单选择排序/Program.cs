using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_简单选择排序
{
    internal class Program
    {
        /// <summary>
        /// 简单选择排序
        /// </summary>
        /// <param name="dataArray">需要排序的数组</param>
        static void SelectSort(int[] dataArray)
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                int min = dataArray[i];
                int minIndex = i; // 最小值所在索引
                for (int j = i + 1; j < dataArray.Length; j++)
                {
                    if (dataArray[j] < min)
                    {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            SelectSort(data);
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
