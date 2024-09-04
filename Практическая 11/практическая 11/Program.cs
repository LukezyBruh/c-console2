/* Гуреева И.Д. 04.12.2021
 Выполнить сортировку элементов массива кратных 3 и 2 (остальные элементы 
остаются на своих местах).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int row = 10; // границы строчки
            int i, min, j, nMin; // переменные по приколу
            int[] mas = new int[row];
            Random rnd = new Random();

            Console.WriteLine("Вывод исходного массива: ");
            Console.WriteLine("Шо то говно ");
            for (i = 0; i < mas.Length; i++) 
            {
                mas[i] = rnd.Next(10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(); // вывод исходного массива
            for (i = 0; i < row; i++)
            {
                min = mas[i];
                nMin = i;
                for (j = i + 1; j < row; j++)
                {
                    if ((mas[i] % 2 == 0 && mas[i] % 3 == 0 )&& min > mas[j])
                    {
                            min = mas[j];
                            nMin = j; 
                    }
                }
                mas[nMin] = mas[i];
                mas[i] = min;
            }
            Console.WriteLine("Отсортированный массив = ");
            for (i = 0; i < row; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Шо это ");
            Console.ReadKey();//пауза
        }
    }
}
