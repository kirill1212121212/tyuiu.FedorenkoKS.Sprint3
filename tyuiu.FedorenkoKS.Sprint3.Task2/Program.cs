using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedorenkoKS.Sprint3.Task2.V13.Lib;

namespace Tyuiu.FedorenkoKS.Sprint3.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Федоренко К. С. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Федоренко Кирилл Сергеевич | ИСПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Оператор цикла do-while                                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага  = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}