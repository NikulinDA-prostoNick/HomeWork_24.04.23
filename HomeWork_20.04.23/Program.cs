﻿// Task2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)

System.Console.WriteLine("Меньшее число: " + a + ", большее число: " + b);
else System.Console.WriteLine($"Меньшее число: {a}, большее число: {b}");
