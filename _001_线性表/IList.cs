﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(int index, T item);
        T Delete(int index);
        T this[int index] { get; }
        T GetEle(int index);
        int Locate(T value);
    }
}
