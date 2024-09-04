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
                min = 0,
                max = 0; // ввод переменных
            int[] mas = new int[n];
            Random rnd = new Random();
            Console.WriteLine("Введите А = ");
            A = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++) mas[i] = rnd.Next(100);
            min = mas[0];
            for (i = 1; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                    if (max < mas[i])
                        max = mas[i];

                if (mas[i] == A && min % A == 0)
                {
                    if (min > mas[i])
                        min = mas[i];
                }   
            }
            
            for (i = 0; i < n; i++) Console.Write(mas[i] + "  ");

            Console.WriteLine("Максимальное " + max);
            Console.WriteLine("Минимальное " + min);
            Console.ReadKey();
        }
    }
}
