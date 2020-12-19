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
            Console.WriteLine($"CustomList Length: {customList.Length}");
            customList.Add(1);
            customList.Add(3);
            customList.Add(3333);
            customList.Add(-444);
            customList.Add(444);
            customList.Add(1);
            Console.WriteLine($"CustomList Length(6): {customList.Length}");
            customList.Add(3333);
            customList.Add(-444);
            customList.Add(444);
            customList.Add(1);
            Console.WriteLine($"CustomList Length(10): {customList.Length}");
            customList.Add(3333);
            customList.Add(-444);
            customList.Add(444);
            customList.Add(1);
            Console.WriteLine($"CustomList Length(14): {customList.Length}");

            Console.ReadKey();
        }
    }
}
