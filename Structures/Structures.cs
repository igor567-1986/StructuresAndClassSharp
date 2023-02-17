using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//****************модификаторы доступа****************
/*private - данные доступны только внутри класса и вложенным классам
protected - данные доступны только внутри класса и вложенным классам или в любом из дочерних классов
internal - данные доступны только методам в текущей сборке
protected internal - данные доступны только методам вложенных и дочерних классов внутри сборки
public - данные доступны везде и всем*/


namespace Structures
{
    struct Dimensions
    {
        private double Length;
        public double Width;

        public Dimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void Print()
        {
            WriteLine($"Длина {Length}, ширина {Width}.");
        }
    }

    class Student
    {
        int _studentID;
        string _firstName = "John";
        string _lastName = "Connor";
        string _group;

        public void Print()
        {
            WriteLine($"Студент {_firstName} {_lastName}");
        }
    }

    class Structures
    {
        static void Main(string[] args)
        {
            Student st1;
            st1 = new Student();
            st1.Print();

            Student st2 = new Student();
            st2.Print();


            double length = 3.456, width = 6.789;
            Dimensions dimensions = new Dimensions(length, width);
            dimensions.Print();
        }
    }
}
