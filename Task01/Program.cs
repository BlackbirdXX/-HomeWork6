// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
using static System.Console;
using System.Linq;
Clear();

WriteLine("Программа, которая считает сколько чисел больше 0 \nввёл пользователь.");
WriteLine("Введите элементы массива через пробел.");

int array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Count(x => x > 0);
WriteLine(array);
