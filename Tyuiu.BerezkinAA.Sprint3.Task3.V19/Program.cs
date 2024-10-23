using Tyuiu.BerezkinAA.Sprint3.Task3.V19.Lib;

namespace Tyuiu.BerezkinAA.Sprint3.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2 в строке:            *");
            Console.WriteLine("* sxxrrg x vfrx                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string value = "sxxrrg x vfrx";
            char replaceable = 'x';
            char replacement = '2';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Заменяемый символ: " + replaceable);
            Console.WriteLine("Замена: " + replacement);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Строка с заменой символов:  " + ds.ReplaceCharOnNum(value, replaceable, replacement));
        }
    }
}
