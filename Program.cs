using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            Console.WriteLine($"CustomList Length: {customList.Count}");
            List<int> listToAdd = new List<int>();
            for(int i = 0; i < 7; i++)
            {
                listToAdd.Add(i);
            }
            customList.AddRange(listToAdd);
            Console.WriteLine($"CustomList Length(8): {customList.Count}");
            customList.AddRange(listToAdd);
            customList.AddRange(listToAdd);
            Console.WriteLine($"CustomList Length(16): {customList.Count}");

            customList.Print();
            customList.Sort();
            customList.Print();

            Console.WriteLine($"Index of 3: {customList.IndexOf(3)}");
            Console.WriteLine($"Index of -666: {customList.IndexOf(-666)}");

            listToAdd = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                listToAdd.Add(i);
            }
            customList = new CustomList<int>();
            customList.AddRange(listToAdd);
            customList.Print();
            Console.WriteLine($"CustomList Length: {customList.Count}");
            customList.Insert(3, -666);
            Console.WriteLine($"CustomList Length: {customList.Count}");
            customList.Print();

            Console.ReadKey();
        }
    }
}
