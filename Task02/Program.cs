// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая найдёт точку пересечения двух прямых, \nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
WriteLine("Введите k1:");
float k1 = float.Parse(ReadLine());
WriteLine("Введите b1:");
float b1 = float.Parse(ReadLine());
WriteLine("Введите k2:");
float k2 = float.Parse(ReadLine());
WriteLine("Введите b2:");
float b2 = float.Parse(ReadLine());
GetIntersectionPoint();

void GetIntersectionPoint()
{
    WriteLine($"{(b2 - b1) / (k1 - k2)}, {k1 * (b2 - b1) / (k1 - k2) + b1}");
}