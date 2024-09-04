/* Гуреева И.Д. 11.12.2021
 Удалить из строки все заглавные латинские буквы, а каждую цифру заменить 
числом из трех соответствующих цифр. Удалить все запятые.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Всем привет");
            string text;
            int kol = 0; // кол-во 6
            text = "Иришка не любит вставать в 6 утра, а Настя абоба";
            text = text.Replace("Иришка", "иришка") ;
            text = text.Replace("Настя", "настя");
  
            int indexZ = text.IndexOf(",");
            text = text.Remove(indexZ, 1);

            for( int i = 0; i < text.Length ; i++)
                if (text[i] == '6')
                {
                    kol++;
                }

            text = text.Replace("6", "666");
            Console.WriteLine(text);
            Console.WriteLine("Всем пока");
            Console.ReadKey();
        }
        
    }
}
