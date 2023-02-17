using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Structures
{
    class Car
    {
        private string _driverName;
        private int _currentSpeed = 80;

        public Car(string name = "Михаэль Шумахер")
        {
            _driverName = name;
        }

        public Car(string name, int speed)
        {
            _driverName = name;
            _currentSpeed = speed;
        }

        public void PrintState()
        {
            WriteLine($"{_driverName} едет со скоростью {_currentSpeed} км/ч.");
        }

        public void SpeedUp(int delta)
        {
            _currentSpeed += delta;
        }
    }

    class Constructors
    {
        static void Main(string[] args)
        {
            Car ferrariCar = new Car("Ральф Шумахер");
            for(int i = 0; i < 10; i++)
            {
                ferrariCar.PrintState();
                ferrariCar.SpeedUp(15);
            }

            WriteLine();
            WriteLine();

            Car mcLarenCar = new Car("Льюис Хэмилтон", 95);
            for (int i = 0; i < 10; i++)
            {
                mcLarenCar.PrintState();
                mcLarenCar.SpeedUp(17);
            }
        }
    }
}
