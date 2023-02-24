// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите целое число 1: ");
int digit_1 = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 2: ");
int digit_2 = int.Parse(Console.ReadLine());

if(digit_1 > digit_2)
{
    Console.WriteLine($"Больше число №1 - {digit_1}");
    Console.WriteLine($"Меньше число №2 - {digit_2}");
}
else
{
    Console.WriteLine($"Больше число №2 - {digit_2}");
    Console.WriteLine($"Больше число №2 - {digit_1}");
}