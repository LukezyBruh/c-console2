/*
 Гуреева И.Д. ИСП-23. 13.11.2021
 Найти все целые числа из промежутка от 1 до 300, у которых ровно пять
делителей.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a, // числа
                sum; //делитель

            for ( i = 100; i <= 300; i ++) // 1 цикл, считает числа от 1 до 300
            {
                sum = 0;
                for (a = 100; a <= 300; a++) // перебираем числа делителя
                {
                    if (i % a == 0) // делится без остатка
                        sum += 1;
                }
                if (sum == 50) // если яисло попадает в условие то вывод
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
