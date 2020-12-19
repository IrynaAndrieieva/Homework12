﻿using System;
using System.Collections.Generic;

namespace Homework12
{
    public interface ICustomList<T> where T: IComparable
    {
        void Add(T item);

        void AddRange(ICollection<T> collection);

        int IndexOf(T item);

        void Insert(int index, T item);

        bool Remove(T item);

        void RemoveAt(int index);

        void Sort();
    }
}
