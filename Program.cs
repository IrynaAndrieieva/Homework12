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
            Console.WriteLine($"CustomList Length(16): {customList.Count}");

            Console.ReadKey();
        }
    }
}
