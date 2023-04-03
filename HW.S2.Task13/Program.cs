// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
char[] arr = num.ToString().ToCharArray();

if (arr.Length >= 4)
{
  Console.WriteLine(arr[2]);
}
else
{
  Console.WriteLine("Такой цифры нет");
}
