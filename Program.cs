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

            // test add range
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

            //test sort
            customList.Print();
            customList.Sort();
            customList.Print();

            // test index of
            Console.WriteLine($"Index of 3: {customList.IndexOf(3)}");
            Console.WriteLine($"Index of -666: {customList.IndexOf(-666)}");

            // test insert
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

            // test remove
            listToAdd = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                listToAdd.Add(i);
            }
            customList = new CustomList<int>();
            customList.AddRange(listToAdd);
            Console.WriteLine("Test Remove:\n");
            customList.Print();
            bool isRemoved = customList.Remove(3);
            customList.Print();
            bool isRemoved2 = customList.Remove(-666);
            customList.Print();

            Console.ReadKey();
        }
    }
}
