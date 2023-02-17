using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Structures
{
    class MyClass
    {
        public readonly int Width = 10;
        public readonly int Length = 20;

        public readonly int[] myArr = { 1, 2, 3 };

        public MyClass(int width,int length)
        {
            Width = width;
            Length = length;
        }

        public void Print()
        {
            WriteLine($"Длина {Length}, ширина {Width}.");
        }
    }

    class CodeFile1
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(40,30);
            obj.Print();

            MyClass obj2 = new MyClass(40, 30);
            obj2.Print();
        }
    }
}
