using System;
using System.Collections.Generic; //система для использования динамического массива
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //создаем динамический массив 
            int n = int.Parse(Console.ReadLine()); // считываем сколько чисел нужно ввести 
            string[] a = Console.ReadLine().Split(); //заполняем массив

            foreach (string s in a) //обращаемся к каждому элементу этого массива 
            {
                int sum = 0;

                for (int i = 2; i <= a.Length; i++)
                {
                    if (int.Parse(s) % i == 0) // проверяем делится ли без остатка 
                    {

                        sum += 1; // если да то придавляем один
                    }
                }
                if (sum == 1)
                {
                    list.Add(s); // если число простое то добавляем в динамический массив
                }
            }

            Console.WriteLine(list.Count); //выводим все элементы, что есть в массиве
            foreach (string s in list)
            {
                Console.Write(s + " "); // выводим
            }
            Console.ReadKey(); //система ожидает входящий сигнал, после чего закрывает консоль
        }
    }
}
