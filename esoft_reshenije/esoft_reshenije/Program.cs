using System;
namespace ConsoleApplication
{
    class OurClass
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.Write("Введите первое и второе число:\n");
            try { num1 = float.Parse(Console.ReadLine()); num2 = float.Parse(Console.ReadLine());}
            catch
            {
                Console.WriteLine("Неправильный формат числа!\nОдно из чисел введено неправильно");
                return;
            }
            if (num2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            Console.WriteLine("\n" + num1 + " + " + num2 + " = " + (num1 + num2)
                + "\n" + num1 + " * " + num2 + " = " + (num1 * num2) +
            "\n" + num1 + " - " + num2 + " = " + (num1 - num2) + "\n" + num1 + " / " + num2 + " = " + (num1 / num2));
            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            Console.ReadLine();
        }
    }
}
