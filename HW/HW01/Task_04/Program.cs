// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.Write("Введите целое число 1: ");
int digit_1 = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 2: ");
int digit_2 = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 3: ");
int digit_3 = int.Parse(Console.ReadLine());

List<int> digits = new List<int>() {digit_1, digit_2, digit_3};

int max = digit_1;
int count = digits.Count;
int i = 0;

while(i < count)
{
    if(digits[i] > max)
    {
        max = digits[i];
    }
    
    i += 1;
}

Console.WriteLine($"Максимальное из трех чисел: {max}");
digits.ForEach(Console.Write);

