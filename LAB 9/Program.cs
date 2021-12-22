using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");

            Console.WriteLine("Введите первое целое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                
            }
            catch            
            {
                Console.WriteLine("ОШИБКА! Входная строка имела неверный формат");
            }
            

            Console.WriteLine(@"Выберите код операции:
            - Умножение (введите 1)
            - Деление (введите 2)
            - Сложение (введите 3)
            - Вычитание (введите 4)");


            string Z = Console.ReadLine();

            if (Z=="1")
            {
                Console.WriteLine("Ваш выбор 1. Умножение, результат = {0}", x*y);
            }
            if (Z == "2")
            {
                Console.WriteLine("Ваш выбор 2. Деление, результат = {0}", x / y);
            }

            try
            {
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деление на 0!!!");              
            }


            if (Z == "3")
            {
                Console.WriteLine("Ваш выбор 3. Сложение, результат = {0}", x + y);
            }
            if (Z == "4")
            {
                Console.WriteLine("Ваш выбор 4. Вычитание, результат = {0}", x - y);
            }


            Console.ReadKey();

        }
    }
}
