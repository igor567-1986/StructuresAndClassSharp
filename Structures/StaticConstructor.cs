using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Structures
{
    class Bank
    {
        private double _currBalance;
        private static double _bonus;

        public Bank(double balance)
        {
            _currBalance = balance;
        }

        static Bank()
        {
            _bonus = 1.12;
        }

        public static void SetBonus(double newRate)
        {
            _bonus = newRate;
        }

        public static double GetBonus() 
        {
            return _bonus;
        }

        public double GetPercents(double sum)
        {
            if ((_currBalance - sum) > 0)
            {
                double percent = sum * _bonus;
                _currBalance -= percent;
                return percent;
            }
            return -1;
        }
    }

    class Constructors
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(1000000);
            WriteLine($"Текущий бонусный процент: {Bank.GetBonus()}");
            WriteLine($"Ваш депозит на 100000, в кассе забрать: {b1.GetPercents(100000)}");
        }
    }
}
