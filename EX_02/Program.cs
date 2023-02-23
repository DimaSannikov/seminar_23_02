// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

Console.Write("Введите целое число от 1 до 7: ");
int digit = int.Parse(Console.ReadLine());

if(digit == 1)
{
    Console.WriteLine("Понедельник");
}

if(digit == 2)
{
    Console.WriteLine("Вторник");
}

if(digit == 3)
{
    Console.WriteLine("Среда");
}

if(digit == 4)
{
    Console.WriteLine("Четверг");
}

if(digit == 5)
{
    Console.WriteLine("Пятница");
}

if(digit == 6)
{
    Console.WriteLine("Суббота");
}

if(digit == 7)
{
    Console.WriteLine("Воскресенье");
}

else
{
    Console.WriteLine("Введите число от 1 до 7");
}