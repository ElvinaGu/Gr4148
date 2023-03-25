// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру

// //Вывели сообщение для ввода данных
// Console.WriteLine("Введите день недели");
// string? dayLine = Console.ReadLine();

// if (dayLine != null)
// {
//   //Создание массива
//   string[] dayWeek = new string[7];
//   dayWeek[0] = "Понедельник";
//   dayWeek[1] = "Вторник";
//   dayWeek[2] = "Среда";
//   dayWeek[3] = "Четверг";
//   dayWeek[4] = " Пятница";
//   dayWeek[5] = "Суббота";
//   dayWeek[6] = "Воскресенье";

//   //Преобразовали строку в целочисленное значение
//   int day = int.Parse(dayLine);

//   Console.WriteLine(dayWeek[day - 1]);
// }

Console.WriteLine("Введите день недели");
string? dayLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if (dayLine != null)
{
  int day = int.Parse(dayLine);
  string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));

  Console.WriteLine(outDayOfWeek);
}