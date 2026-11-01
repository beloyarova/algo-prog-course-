bool IsPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

int FindMax(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;
}

double CalculateAverage(int a, int b, int c)
{
    return (a + b + c) / 3.0;
}

Console.WriteLine("Введите первое число: ");
int number1;
if (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Ошибка ввода");
    return;
}
Console.WriteLine("Введите второе число: ");
int number2;
if (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Ошибка ввода");
    return;
}
Console.WriteLine("Введите третье число: ");
int number3;
if (!int.TryParse(Console.ReadLine(), out number3))
{
    Console.WriteLine("Ошибка ввода");
    return;
}

Console.WriteLine();
Console.WriteLine($"{number1} простое: {IsPrime(number1)}");
Console.WriteLine($"{number2} простое: {IsPrime(number2)}");
Console.WriteLine($"{number3} простое: {IsPrime(number3)}");

Console.WriteLine();
Console.WriteLine($"Максимум из трех: {FindMax(number1, number2, number3)}");
Console.WriteLine($"Максимум из первых двух: {FindMax(number1, number2, 0)}");

Console.WriteLine();
Console.WriteLine($"Среднее арифметическое: {CalculateAverage(number1, number2, number3):F2}");