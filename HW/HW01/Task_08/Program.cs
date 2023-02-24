// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int digit = int.Parse(Console.ReadLine());

// int num = 0;

// while(num < digit - 1)
// {
//     num += 2;
//     Console.WriteLine(num);
// }

int num = 1;

while(num < digit)
{
    if(num % 2 == 0)
    {
        Console.WriteLine(num);
    }
    num += 1;

}