using System.Collections;

namespace Homework12
{
    public interface ICustomList<T>
    {
        void Add(T item);

        void AddRange(ICollection collection);

        int IndexOf(T item);

        void Insert(int index, T item);

        bool Remove(T item);

        void RemoveAt(int index);

        void Sort();
    }
}
