using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FedorenkoKS.Sprint3.Task5.V25.Lib;

namespace Tyuiu.FedorenkoKS.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Федоренко К. С. | ИСПб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Вложенные циклы                                      *");
            Console.WriteLine("* Задание #5                                                 *");
            Console.WriteLine("* Вариант #25                                                *");
            Console.WriteLine("* Выполнил :  Федоренко Кирилл К.С.     | ИСПб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("*  найти сумму сумм при x = 2,                               *");
            Console.WriteLine("* sumSeries = sumSeries + (Math.Pow(x, k) + Math.Cos(k));    *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Старт шага первой суммы " + startValue1);
            Console.WriteLine("Конец шага первой суммы " + stopValue1);
            Console.WriteLine("Старт шага втрой суммы " + startValue2);
            Console.WriteLine("Конец шага втрой суммы " + stopValue2);


            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}