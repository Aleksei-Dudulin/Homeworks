// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Hello, I can determine maximal and minimal numbers!");
Console.Write("Write a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1, min = num2;
if (num2 > max)
{
    max = num2;
    min = num1;
}
Console.WriteLine($"Maximal number is {max}, minamal number is {min}");