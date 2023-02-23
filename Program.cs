int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, \n    что такого элемента нет.Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.");
Console.WriteLine("3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
 
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);
 
// Заполнение массива рандомными  числами
void FillArray2D(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(-99, 99) / 10.0;
}
}
}
 
//вывод массива в терминал
void PrintArray2D(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}
 
// Функция ввода 
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
 

 
break;

case 2:
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
 
17 -> такого числа в массиве нет
*/
 
int rows1 = ReadInt("Введите индекс строки: ");
int colums1 = ReadInt("Введите индекс столбца: ");
int[,] numbers1 = new int[6, 8];
FillArray2D1(numbers1);
PrintArray2D1(numbers1);
 
if (rows1 < numbers1.GetLength(0) && colums1 < numbers1.GetLength(1)) Console.WriteLine(numbers1[rows1, colums1]);
else Console.WriteLine($"{rows1}   {colums1} -> такого числа в массиве нет");
 
 
// Заполнение массива рандомными числами
void FillArray2D1(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}
 
// вывод массива в терминал
void PrintArray2D1(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}
 
// Функция ввода 
int ReadInt2(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

break;

case 3:
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
 
// int rows = ReadInt("Введите номер строки: ");
// int colums = ReadInt("Введите номер столбца: ");
 
int rows12 = 3;
int colums12 = 4;
int[,] numbers12 = new int[rows12, colums12];
FillArray2D1(numbers12);
PrintArray2D1(numbers12);
 
double[] avgNumbers = new double[numbers12.GetLength(1)];
 
for (int i = 0; i < numbers12.GetLength(1); i++)
{
double result = 0.0;
for (int j = 0; j < numbers12.GetLength(0); j++)
{
result += numbers12[j, i];
}
avgNumbers[i] = result / numbers12.GetLength(0);
}
PrintArray(avgNumbers);
 
 
// Заполнение массива рандомными числами
void FillArray2D12(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}
 
// вывод двумерного массива
void PrintArray2D12(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}
 
//  вывод массива в терминал 
void PrintArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
 
// Функция ввода 
int ReadInt1(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

break;



default:
begin = false;
break;
}
}