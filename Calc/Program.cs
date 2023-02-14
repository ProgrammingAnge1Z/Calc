using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Допустимые операции: +, -, *, /, tg, ctg");
                Console.Write("\nПервый операнд: "); double a = Convert.ToDouble(Console.ReadLine());
                double b;
                Console.Write("Операция: "); string operation = Convert.ToString(Console.ReadLine());
                switch (operation)
                {
                    case "+":
                        Console.Write("Второй операнд: "); b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Результат = {a + b}");
                        continue;
                    case "-":
                        Console.Write("Второй операнд: "); b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Результат = {a - b}");
                        continue;
                    case "*":
                        Console.Write("Второй операнд: "); b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Результат = {a * b}");
                        continue;
                    case "/":
                        Console.Write("Второй операнд: "); b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Результат = {a / b}");
                        continue;
                    case "tg":
                        Console.WriteLine($"Результат = {Math.Tan(a)}");
                        continue;
                    case "ctg":
                        Console.WriteLine($"Результат = {(1 / Math.Tan(a))}");
                        continue;
                    default:
                        Console.WriteLine("Неккоректное значение операции!");
                        continue;
                }
            }
            Console.ReadKey();
        }
    }
}