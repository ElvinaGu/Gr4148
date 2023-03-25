// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя).

//Считываем данные с консоли
string? inline = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inline != null)
{
  //Парсим введенное число
  int inNumber = int.Parse(inline);

  //Находим квадрат числа
  int outNumber = inNumber * inNumber;
  int outStrtPow = (int)Math.Pow(inNumber, 2);

  //int outNumberTest = inLine.ToCharArray()[0]*inLine.ToCharArray()[0];

  //Выводим данные в консоль
  Console.WriteLine(outNumber);

  //Выводим данные в консоль
  Console.WriteLine(outStrtPow);
}
