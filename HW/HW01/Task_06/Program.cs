// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).

Console.Write("Введите целое число: ");
int digit = int.Parse(Console.ReadLine());

int even = digit % 2;

if(even == 0)
{
    Console.WriteLine($"Число {digit} является четным ");
}
else
{
    Console.WriteLine($"Число {digit} является нечетным");
}
