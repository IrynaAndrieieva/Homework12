using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    public class CustomList<T> : ICustomList<T>
    {
        private T[] Data;
        public int Length { get; private set; }
        private int Capacity => Data.Length;
        public CustomList()
        {
            Data = new T[10];
            Length = 0;
        }

        private void Resize(int numberOfElements)
        {
            int desiredCapacity = this.Length + numberOfElements;
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
            this.Data[Length] = item;
            this.Length++;

        }

        public void AddRange(ICollection collection)
        {
            throw new NotImplementedException();
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

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
