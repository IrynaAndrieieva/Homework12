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
            List lis = new List(3);

            Console.WriteLine(lis.Print("Test:"));

            Random rnd = new Random();
            lis.Add(rnd.Next(1, 10000));
            
            lis.Add(56);

            lis.Sort();

            Console.WriteLine(lis.Print());

            Console.ReadKey();
        }
    }
}
