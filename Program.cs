// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

//System.Console.Write("Введите количество элементов в массиве: ");

// int size = 10;
// int[] myArray = new int[size];
// Random rand = new Random();

// // Заполнение массива случайными числами от 1 до 100

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = rand.Next(1, 100);
// }

// // Вводим массив 
// for (int i = 0; i < myArray.Length; i++)
// Console.Write($"{myArray[i],3}");

// // Подсчет элементов которые лежат в отрезке [20,90].
// int count = 0; 
// for(int i = 0; i <myArray.Length; i++)
// {
//     if(myArray[i]>=20 && myArray[i] <=90)
//     count++;

// }
// Console.WriteLine();
// System.Console.WriteLine(count);


// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


// int size = 10;
// int[] myArray = new int[size];
// Random rand = new Random();

// for (int i = 0; i < myArray.Length; i++)
//  {
//     myArray[i] = rand.Next(1, 10);
//  }

// // Вводим масив 
//  Console.Write("Массив: ");
//  foreach(int num in myArray)
//  {
//     Console.Write($"{num} ");
//  }

// // Подсчет четных чисел 

// int count = 0; 
// foreach(int num in myArray)
// {
//     if(num % 2 == 0)
//    {
//     count++;
//    } 
// }
// Console.WriteLine();
// System.Console.WriteLine($"Количество чётных чисел в массиве: {count}");

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] myArray = {12.34, 5.67, 23.45, 9.12, 7.89, 15.78, 30.45, 8.91, 18.23, 42.56};

// Вводим масив 

Console.Write("Массив: ");
foreach(double num in myArray)
{
     Console.Write($"{num} ");
}

// Нахождение максимального и минимального элементов
double maxElement = myArray[0];
double minElement = myArray[0];

foreach(double num in myArray)
{
    if( num > maxElement)
        maxElement = num; 
    if(num < minElement)
        minElement = num;
}
// Нахождение разницы между максимальным и минимальным элементов массива.

double defference =  maxElement -  minElement;

Console.WriteLine();
System.Console.WriteLine($"Минимальный: {minElement}");
System.Console.WriteLine($"Максимальный: {maxElement}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {defference}");




