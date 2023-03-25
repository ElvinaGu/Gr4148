// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

Console.Write("Введите 3-х значное число: ");
string? numLine = Console.ReadLine();
if (numLine != null)
{
  // char[] charAvr = numLine.ToCharArray();    //Преобразование в массив
  // Console.WriteLine(charAvr[charAvr.Length - 1]);

  int num = int.Parse(numLine);
  int res = num % 10; //% - остаток от деления на 10
  Console.WriteLine(res);
}
