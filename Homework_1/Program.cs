// ******************************************** ДЗ 1 *************************************************

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

// ******************************************** ДЗ 2 *************************************************

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

// ******************************************** ДЗ 3 *************************************************

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Polindrom(int number)
{
    int num1 = number % 10; int num2 = number / 10000; int num3 = (number % 10000) / 1000; int num4 = (number % 100) / 10;
    if (num1 == num2 && num3 == num4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Please, input a 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Polindrom(num);
Console.WriteLine($"Number {num} is polidrom - it is {result}.");
*/
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Length(double x1, double y1, double z1,  double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}

Console.Write("Input coordinate X1: ");
double numx1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Y1: ");
double numy1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Z1: ");
double numz1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate X2: ");
double numx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Y2: ");
double numy2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Z2: ");
double numz2 = Convert.ToInt32(Console.ReadLine());

double lengthXY = Length(numx1, numy1, numz1, numx2, numy2, numz2);

Console.Write($"The length of segment between X and Y is {lengthXY}");
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeNumbers(int num)
{
    int i = 0;
    while(i <= num)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeNumbers(number);
*/

// ******************************************** ДЗ 4 *************************************************

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int FindAvB(int A, int B)
{
    int result = A;
    for(int current = 1; current < B; current++)
        result *= A;
    return result;
}

Console.Write("Input a first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

int answer = FindAvB(numA, numB);

Console.WriteLine($"{numA} ^ {numB} = {answer}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int FindSum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = FindSum(num);

Console.WriteLine($"Sum of all numbers is {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void FillArray(int[] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
        array[i] = new Random().Next(1,10);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count; pos++)
        Console.Write(col[pos] + " ");
}

int[] result = new int [8];
FillArray(result);
PrintArray(result);
*/

// Задача 29*: Напишите программу, которая задаёт массив из элементов, запрашиваемых у пользователя, и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input element of array: ");
        int current = Convert.ToInt32(Console.ReadLine());
        array[i] = current;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] NewArray = CreateArray(size);
ShowArray(NewArray);
*/

// ******************************************** ДЗ 5 *************************************************

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
void CreateArray(int[] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
        array[i] = new Random().Next(100,1000);
}
*/
/*
void ShowMeArray(int[] createArray)
{
    for(int j = 0; j < createArray.Length; j++)
        Console.Write(createArray[j] + " ");
    Console.WriteLine();
}
*/
/*
int CountEven(int[] someArray)
{
    int count = 0;
    for(int i = 0; i < someArray.Length; i++)
        if(someArray[i] % 2 == 0)
            count += 1;
    return count;
}

Console.Write("Input quantity of array elements: ");
int q = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[q];
CreateArray(myArray);
ShowMeArray(myArray);
int result = CountEven(myArray);
Console.WriteLine($"Quantity of even numbers is {result}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
*/
/*
int SumUneven(int[] col)
{
    int result = 0;
    for(int i = 1; i < col.Length; i += 2)
        result += col[i];
    return result;
}

Console.Write("Input quantity of array elemets: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] randomArray = CreateRandomArray(q, min, max);
ShowMeArray(randomArray);
Console.WriteLine($"Sum value of array elements with uneven index is {SumUneven(randomArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateFractionalArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    return array;
}

void ShowMyArray(double[] createNewArray)
{
    for(int j = 0; j < createNewArray.Length; j++)
        Console.Write(createNewArray[j] + " ");
    Console.WriteLine();
}

double Difference(double[] someFractionalArray)
{
    int posMax = 0;
    int posMin = 0;
        
    for(int k = 1; k < someFractionalArray.Length; k++)
        if(someFractionalArray[k] > someFractionalArray[posMax])
            posMax = k;
        else
            if(someFractionalArray[k] < someFractionalArray[posMin])
                posMin = k;
    double difference = someFractionalArray[posMax] - someFractionalArray[posMin];
    return difference;
}

Console.Write("Input quantity of array elemets: ");
int quan = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value: ");
int numMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value: ");
int numMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[] fractionalArray = CreateFractionalArray(quan, numMin, numMax);
ShowMyArray(fractionalArray);
double diff = Difference(fractionalArray);
Console.WriteLine($"Difference between max and min elements is {diff}");
Console.WriteLine();
*/

// ******************************************** ДЗ 6 *************************************************

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 1 способ
/*
int[] FillArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) count++;
    return count;
}

Console.Write("How much numbers you want input: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] myArray = FillArray(quantity);
Console.WriteLine();
ShowArray(myArray);
Console.WriteLine();
int result = CountPositiveNumbers(myArray);
Console.WriteLine($"You inputed {result} positive number(s)");
*/
// 2 способ
/*
Console.Write("How much numbers you want input: ");
int q = Convert.ToInt32(Console.ReadLine());  
int count = 0;
for(int i = 0; i < q; i++)
    {
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
            {
                count++;
                Console.WriteLine($"You inputed {count} positive number(s)"); 
            }
        else Console.WriteLine($"You inputed {count} positive number(s)");
    }
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
/*
double[] IntersectionPoint(double k1, double b1, double k2, double b2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        
        double[] array = {x, y};
        return array;
    }


void ShowArray(double[] array)
{
    Console.Write($"Coordinates of intersection point x;y is ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ";" + " ");
    
    Console.WriteLine();
}

Console.WriteLine("Hello, user, we have equations of two lines: y = k1 * x + b1 and y = k2 * x + b2."
                 + " You must input k1, b1, k2, b2");

Console.Write("Please, input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input k1: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input b1: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2 && b1 == b2) 
    {
        Console.WriteLine("These two lines are parallel, therefore always x = y and all points with "
                         +"coordinates are common points of these lines.");
    }
else
    {
        double[] coordinateArray = IntersectionPoint(k1, b1, k2, b2);
        ShowArray(coordinateArray);
    }
*/

// ******************************************** Homework 7 *************************************************

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    }
    return array;
}

void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Please, input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value: ");
int numMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value: ");
int numMax = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(rows, columns, numMin, numMax);
Show2Array(myArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int PositionToValue(int[,] array, int numi, int numj)
{
    int value = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(numi > array.GetLength(0) || numj > array.GetLength(1))
            {
                value = -1;
                break;
            }
            else if(i == numi && j == numj) value = array[i,j];
        }
    }
    return value;
}

Console.Write("Hello, at first, lets create a random array. Please, input quantity of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandomArray(r, c, min, max);
ShowArray(newArray);
Console.Write("Good, now, input position in row: ");
int posrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position in column: ");
int poscol = Convert.ToInt32(Console.ReadLine());

int result = PositionToValue(newArray, posrow, poscol);
if(result == -1) Console.WriteLine($"There is no element with position [{posrow},{poscol}], try again.");
else Console.WriteLine($"Value of element in position [{posrow},{poscol}] is {result}.");
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[] AverageArray(double[,] array)
{
    double[] averArray = new double[array.GetLength(1)];

    for(int j = 0, x = 0; j < array.GetLength(1); j++, x++)
        for(int i = 0; i < array.GetLength(0); i++)
        {
            averArray[x] += array[i,j] / array.GetLength(0);
        }
    return averArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(Math.Round(array[i], 1) + " ");
    }
}

Console.Write("Hello, at first, lets create a random array. Please, input quantity of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] newArray = CreateRandomArray(r, c, min, max);
Show2Array(newArray);
Console.WriteLine();
double[] myAverageNewArray = AverageArray(newArray);
ShowArray(myAverageNewArray);
*/

// ******************************************** Homework 8 *************************************************

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Hello, at first, lets create a random array. Please, input quantity of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandomArray(r, c, min, max);
ShowArray(newArray);
Console.WriteLine();

void ChangElementsMaxToMin(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,j] < array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

ChangElementsMaxToMin(newArray);
ShowArray(newArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}


Console.Write("Hello, at first, lets create a rectangular (no square) array. Please, input quantity of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

if (r == c) 
{
    Console.WriteLine("This is a square array, please, input new data, press Ctrl + C");
}
else
Console.Write("Input integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateRandomArray(r, c, min, max);
ShowArray(newArray);
Console.WriteLine();

int SumElementsOfOneLine(int[,] array, int row)
{
    int sumOneLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumOneLine += array[row, j];
    }
    return sumOneLine;
} 

int minSumLine = SumElementsOfOneLine(newArray, 0);
int numLine = 1;

for(int k = 1; k < r; k++)
{
    int temp = SumElementsOfOneLine(newArray, k);
    if(temp < minSumLine) 
    {
        minSumLine = temp;
        numLine = k + 1;
    }
}
int result = numLine;
Console.WriteLine($"{result} line have minimal sum of elements");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input quantity of rows matrix 1: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of columns matrix 1: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value matrix 1: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value matrix 1: ");
int max1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateRandomArray(r1, c1, min1, max1);
Console.WriteLine();
ShowArray(matrix1);
Console.WriteLine();

Console.WriteLine($"Quantity of rows matrix 2 is {c1}");
int r2 = c1;
Console.Write("Please, input quantity of columns matrix 2: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer min possible value matrix 2: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer max possible value matrix 2: ");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = CreateRandomArray(r2, c2, min2, max2);
Console.WriteLine();
ShowArray(matrix2);
Console.WriteLine();

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] array12 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array12.GetLength(0); i++)
    {
        for (int j = 0; j < array12.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array12[i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return array12;
}

int[,] matrix12 = MultiplyMatrix(matrix1, matrix2);
Console.WriteLine("The result of multiply matrix 1 and matrix 2 is next matrix:");
Console.WriteLine();
ShowArray(matrix12);
Console.WriteLine();

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] Create3DArray(int x, int y, int z)
{
    int[,,] array = new int[x,y,z];
    int maxValue = 99;
    int temp = new Random().Next(10, 100);

    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++)
            {
                array[i,j,k] = temp;
                if(temp < maxValue)
                {
                    temp++;
                }
                else temp = 10;
            }
    return array;
}

void Show3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i,j,k] + "(" + i + "," + j + "," + k + ")" + " ");

            Console.WriteLine();
        }
}

Console.Write("Hello, at first, lets create an 3D array. Please, input quantity of first dimension x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of second dimension y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input quantity of third dimension z: ");
int z = Convert.ToInt32(Console.ReadLine());

if(x*y*z > 90) Console.WriteLine("Incorrect dimension of the array (x * y * z > 90), please, reinput x, y, z.");
else
{
    int[,,] newArray = Create3DArray(x, y, z);
    Show3DArray(newArray);
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Create4x4Array(int n)
{
    
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++, n++)
            {
                array[i, j] = n;
            }
    }

    // внешний последний столбец.
    for (int x = 1, y = array.GetLength(1) - 1, m = 1; x < array.GetLength(0); x++, m++)
    {
        array[x,y] = array[0, array.GetLength(1) - 1] + m;
    }
    // внешняя последняя строка.
    for (int x = array.GetLength(0) - 1, y = array.GetLength(1) - 2, m = 1; y >= 0; y--, m++ )
    {
        array[x,y] = array[array.GetLength(0) - 1, array.GetLength(1) - 1] + m;
    }
    // внешний первый столбец.
    for (int x = array.GetLength(0) - 2, y = 0, m = 1; x > 0; x--, m++ )
    {
        array[x,y] = array[array.GetLength(0) - 1, 0] + m;
    }
    // внутренняя верхняя строка.
    for (int x = 1, y = 1, m = 1; y < array.GetLength(1) - 1; y++, m++ )
    {
        array[x,y] = array[array.GetLength(0) - 3, 0] + m;
    }
    // внутренняя нижняя строка.
    for (int x = 2, y = 2, m = 1; y > 0; y--, m++ )
    {
        array[x,y] = array[array.GetLength(0) - 3, array.GetLength(1) - 2] + m;
    }
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Hello, please, input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Create4x4Array(num);
ShowArray(newArray);