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


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите какое-нибудь число: ");
int number = int.Parse(Console.ReadLine()!);

if(number%2==0)
{
    Console.WriteLine("Введенное Вами число - четное ");
}
else
{
    Console.WriteLine("Введенное Вами число - нечетное ");
}


