using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    struct List
    {
        private int[] data;
        private int index;

        public List(int SizeList)
        {
            this.data = new int[SizeList];
            this.index = 0;
        }

        public void Add(int Element)
        {
            if (index >= this.data.Length)
            {
                Array.Resize(ref this.data, this.data.Length * 3 / 2); //100 >> 150 >> 225 >> 337 >> 505 и т.д. 
            }
            this.data[index++] = Element;
        }
        public void RemoveAt(int Position)
        {
            for (int i = Position; i < this.index; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.index--;
        }

        public string Print(string Text = "")
        {
            string output = string.Empty;
            for (int i = 0; i < this.index; i++) output += $"{this.data[i]} ";
            return $"{Text} {output}".Trim();
        }

        public int this[int i]
        {
            get { return this.data[i]; }
            set { this.data[i] = value; }
        }

        public int Count { get { return this.index; } }

        public void Sort()
        {
            int temp;
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
          
            Console.WriteLine("Make Sort");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.ReadLine();
        }
    }
}

