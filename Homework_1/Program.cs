// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Hello, I can determine maximal of three numbers!");
Console.Write("Write a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine($"Maximal number is {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Hello, I can determine even and uneven numbers!");
Console.Write("Write a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
Console.Write($"Number {num} is even.");
else
Console.WriteLine($"Number {num} is uneven.");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Hello, I can show you all the even numbers from 1 to the number you write!");
Console.Write("Write a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
 
while (i <= N)
{
    Console.Write(i + " ");
    i += 2;
}
*/

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int number)
{
    int result = (number % 100) / 10;
    return result;
}

Console.Write("Input a three-digit number: ");
int N = Convert.ToInt32(Console.ReadLine());

int secNum = SecondNumber(N);

Console.WriteLine($"Second number of {N} is {secNum}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumber(int num)
{
    int num3 = 0; 
    while (num > 999 || num < -999) num = Math.Abs(num / 10);
    if (num > -100 && num < 100) num3 = 11;
    else if (num > -1000 || num < -99 || num > 99 || num <1000) num3 = Math.Abs(num % 10);
    return num3;
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int answer = ThirdNumber(N);
if (answer == 11) Console.WriteLine("Please write another number, your number doesn't have a third digit");
else Console.WriteLine($"A third digit of your number {N} is {answer}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekDay(int num)
{
    if (num > 0 && num < 6) 
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.Write("Input the day of the week and I will check if it is a weekend: ");
int day = Convert.ToInt32(Console.ReadLine());

bool result = WeekDay(day);

Console.WriteLine(result);
*/