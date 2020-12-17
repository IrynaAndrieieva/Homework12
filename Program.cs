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

            Random r = new Random();

            for (int i = 0; i < 30; i++)
            {
                lis.Add(r.Next(100));
            }

            lis.Add(11235813);

            Console.WriteLine(lis.Print());

            Console.ReadKey();
        }
    }
}
