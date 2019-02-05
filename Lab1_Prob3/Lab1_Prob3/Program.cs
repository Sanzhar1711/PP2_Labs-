using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //cчитываем количесто чисел которые будет введено
            string[] a = Console.ReadLine().Split(); // читаем строку разделяя их по пробелам
            List<string> number = new List<string>(); // создаем динамический массив


            foreach (string s in a) //обращаемся к каждому элементу
            {
                number.Add(s); //добавляем с массива
                number.Add(s); // еще раз добавляем
            }

            foreach (string s in number)
            {
                Console.Write(s + ' '); //вывод
            }
            Console.ReadKey();
        }
    }
}
