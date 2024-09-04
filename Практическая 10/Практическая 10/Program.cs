using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5, m = 5; // размер массива строки и столбцы
            int i, j, // индексы массива
                kol=0; // счетчик
            int [] mas = new int[m]; // массив
            int [,] matr = new int[n, m]; // матрица
            Random rnd = new Random(); // рандомчик

            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++) matr[i, j] = rnd.Next(20); // задаем границы 

            Console.WriteLine("Исходный массив"); 
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                Console.Write("{0,5}", matr[i,j]);
                Console.WriteLine();
            } // делаем так, чтобы показывало матрицу, все очень легко и просто (нет)
            for (i = 0; i < n; i++) // просматриваем кадый столбец
            {
                kol = 0; // обнуляет количество для каждого столбца
                for (j = 0; j < m; j++) // просматриваем каждый элемент массива
                    if (matr[i, j] % 2 != 0) kol++; // условие
                mas[i] = kol; // записываем кол столбца во вспомогательный массив
                Console.WriteLine("Количество нечетных элементов = " + kol); 
            }
            Console.WriteLine(); // прикольная строчка
            Console.ReadKey(); // редкей
        }
    }
}
