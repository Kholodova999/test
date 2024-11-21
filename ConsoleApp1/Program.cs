using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Введите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию (+, -, *, /):");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");//поменяли знак на -
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
                break;

            default:
                Console.WriteLine("Недопустимая операция.");
                break;
        }

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}
