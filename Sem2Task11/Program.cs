// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет 
// вторую цифру этого числа.
// 123 -> 13

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int firstNum = num / 100;
int LastNum = num % 10;
int newNum = firstNum * 10 + LastNum;
Console.WriteLine(newNum);
