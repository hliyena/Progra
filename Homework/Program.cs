// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine("Первое чило больше второго");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine("Второе число больше первого");
    }
    else
    {
        Console.WriteLine("Оба числа равны");
    }
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number3 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number4 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int number5 = int.Parse(Console.ReadLine()!);
int max = number3;

if (max < number4)
{
    max = number4;
}
if (max < number5)
{
    max = number5;
}
Console.WriteLine($"Максимальное число = {max}");