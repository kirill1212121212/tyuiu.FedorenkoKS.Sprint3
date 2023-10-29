using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedorenkoKS.Sprint3.Task7.V7.Lib;

namespace Tyuiu.FedorenkoKS.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Федоренко К.С. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Федоренко Кирилл Сергеевич | ИСПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = cos(x) + (cos(x) / (x + 2)) - 3x                                 *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5]           *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль.                         *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int Start = -5;
            int Stop = 5;
            Console.WriteLine("Начальное значение = " + Start);
            Console.WriteLine("Конечное значение = " + Stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            DataService ds = new DataService();
            int X = Start;
            foreach (double i in ds.GetMassFunction(Start, Stop))
            {
                Console.WriteLine("|{0,10:d}|{1,10:f2}|", X, i);
                X++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}