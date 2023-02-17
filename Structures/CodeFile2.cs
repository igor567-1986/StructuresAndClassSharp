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
        public static float balance = 1000000;
    }

    class CodeFile2
    {
        static void Main(string[] args)
        {
            Bank filial1 = new Bank();
            Bank filial2 = new Bank();

            WriteLine($"Первому филиалу доступно {Bank.balance}");
            WriteLine($"Второму филиалу доступно {Bank.balance}");
            WriteLine($"В первом филиале взяли кредит на 100000, осталось {Bank.balance -= 100000}");
            WriteLine($"Второму филиалу доступно {Bank.balance}");
            WriteLine($"Во втором филиале взяли кредит на 200000, осталось {Bank.balance -= 200000}");
            WriteLine($"Первому филиалу доступно {Bank.balance}");
            WriteLine($"В первом филиале открыли депозит на 300000, осталось {Bank.balance += 300000}");
            WriteLine($"Второму филиалу доступно {Bank.balance}");
        }
    }
}
