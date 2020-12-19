using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    public class CustomList<T> : ICustomList<T> where T : IComparable
    {
        private T[] Data;
        public int Count { get; private set; }
        private int Capacity => Data.Length;
        public CustomList()
        {
            Data = new T[10];
            Count = 0;
        }

        private void Resize(int numberOfElements)
        {
            int desiredCapacity = this.Count + numberOfElements;
            if (this.Capacity < desiredCapacity)
            {
                var ourList = this.Data;
                this.Data = new T[desiredCapacity + 10];
                for (int i = 0; i < ourList.Length; i++)
                {
                    this.Data[i] = ourList[i];
                }
            }
        }

        public void Add(T item)
        {
            this.Resize(1);
            this.Data[Count] = item;
            this.Count++;
        }

        public void AddRange(ICollection<T> collection)
        {
            this.Resize(collection.Count);
            foreach (var item in collection)
            {
                this.Data[Count] = item;
                this.Count++;
            }
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
        public void Print()
        {
            Console.WriteLine("Your custom list:");

            for (int i = 0; i < this.Count; i++)
            {
                Console.Write($"{this.Data[i]} ");
            }
            Console.WriteLine("\n");

        }
        public void Sort()
        {
            for (int i = 0; i < this.Data.Length - 1; i++)
            {
                for (int j = i + 1; j < this.Data.Length; j++)
                {
                    if (this.Data[i].CompareTo(this.Data[j]) == 1)
                    {
                        T temp = this.Data[i];
                        this.Data[i] = this.Data[j];
                        this.Data[j] = temp;
                    }
                }
            }
        }
    }
}
