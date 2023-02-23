// Команда вывода в консоль
// Console.WriteLine("Hello, GeekBrains!");
// Console.WriteLine(100 + 1);

// Пользователь вводит, программа толжна выводить это число
// умноженное само на себя

// Console.Write("Введите целое число: ");
// int digit = int.Parse(Console.ReadLine());

// int result = digit * digit;
// Console.WriteLine($"Квадрат входного числа равен {result}");

Console.WriteLine("Введите целое число 1: ");
int digit_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите целое число 1: ");
int digit_2 = int.Parse(Console.ReadLine());

int result = digit_2 * digit_2;

if(digit_1 == result)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

