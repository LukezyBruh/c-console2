/* 
В одномерном массиве целых чисел найти максимальный среди элементов, 
являющихся четными, и минимальный среди элементов, кратных А 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, 
                A, 
                n = 10, // размер массива
                min = 999,
                max = -1; // ввод переменных
            int[] mas = new int[n]; // создание массива
            Random rnd = new Random(); // рандомный набор чисел
            Console.WriteLine("Введите А = ");
            A = Convert.ToInt32(Console.ReadLine()); 
            for (i = 0; i < n; i++) mas[i] = rnd.Next(0,20);
            for (i = 0; i < n; i++) // прикольная строчка
            {
                if (((mas[i] % 2) == 0) && max < mas[i]) // задаем, что макс будет кратный 2-х
                {
                        max = mas[i];
                }
               
                if (((mas[i] % A) == 0) && min > mas[i])
                {
                    min = mas[i];
                   
                }
     
            }
            for (i = 0; i < n; i++) Console.Write(mas[i] + "  ");// всем привет, тут вывод чисел массива
            Console.WriteLine("Максимальное " + max);
            Console.WriteLine("Минимальное " + min);
            Console.ReadKey(); // хочу убиться
        }
    }
}
