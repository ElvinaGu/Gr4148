// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N

string? numberLine = Console.ReadLine();
if (numberLine != null)
{
  int numN = int.Parse(numberLine); // Преобразовали со строки в число
  int startNum = numN * (-1); // Создали переменную и положили в нее отрицательно введенное значение 
  string result = String.Empty; // Создали переменную, в которой накапливали ответ

  while (startNum <= numN)
  {
    // Накапливаем по одному значению и увеличиваем на единицу
    result = result + startNum + "_";
    startNum = startNum + 1;
  }
  Console.WriteLine(result);
}
