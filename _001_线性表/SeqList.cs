using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    class SeqList<T> : IListDS<T>
    {

        private T[] data; // 用来存储数据
        private int count = 0; // 表示存储了多少个数据

        /// <summary>
        /// 初始化列表
        /// </summary>
        /// <param name="size">最大容量</param>
        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }

        /// <summary>
        /// 默认构造函数，容量是10
        /// </summary>
        public SeqList() : this(10)
        {

        }

        /// <summary>
        /// 通过所引器访问元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>索引处的值</returns>
        public T this[int index]
        {
            get { return GetEle(index); }
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="item">要添加的元素</param>
        public void Add(T item)
        {
            if (count == data.Length)
            {
                // 当前数组已经存满了
                Console.WriteLine("当前顺序表已经存满，不允许再存入！");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void Clear()
        {
            count = 0;
        }

        /// <summary>
        /// 删除索引处的值
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>被删除的元素</returns>
        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i]; // 把数据向前移动
            }
            count--;
            return temp;
        }

        /// <summary>
        /// 根据索引取得值
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>索引对应的值</returns>
        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                // 索引存在
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在！");
                return default(T); // 返回T类型的默认值
            }
        }

        /// <summary>
        /// 取得数据的个数
        /// </summary>
        /// <returns>数据的个数</returns>
        public int GetLength()
        {
            return count;
        }

        /// <summary>
        /// 再索引处插入数据
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="item">插入的数据</param>
        public void Insert(int index, T item)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        /// <summary>
        /// 判断当前列表是否为空
        /// </summary>
        /// <returns>列表是否为空</returns>
        public bool IsEmpty()
        {
            return count == 0;
        }

        /// <summary>
        /// 根据值取得索引
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>值再列表中的索引，不存在则返回-1</returns>
        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
