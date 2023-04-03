﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите 3-х значное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (99 < num && num < 1000)
{
  Console.WriteLine("Вторая цифра числа " + num + " это " + (num / 10) % 10);
}
else
{
  Console.WriteLine("Введено не 3-х значное число");
}
