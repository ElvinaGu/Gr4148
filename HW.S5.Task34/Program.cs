// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод заполнения массива трехзначными положительными числами
int[] Gen1DArr(int len)
{
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(100, 1000);
  }
  return arr;
}

//Метод вывода массива
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод вывода результата
void PrintResult(string msg, long res)
{
  Console.WriteLine(msg + res);
}

//Метод подсчета кол-ва четных чисел в массиве
int EvenCount(int[] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0) res++;
  }
  return res;
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArr(lenArr);
Print1DArr(arr);
PrintResult("Количество четных чисел в массиве: ", EvenCount(arr));

// *Отсортировать массив методом пузырька и подсчета. 
// Сравнить быстродействие методов. Проверку сортировки производить отдельно.
// Сначало запустить программу с одним методом сортировки, а затем с другим.
// Проверять на длине массива не мение 10000 элементов.

//Метод пузьрковой сортировки
void BubbleSort(int[] mas)
{
  int temp = 0;
  for (int i = 0; i < mas.Length; i++)
  {
    for (int j = 0; j < mas.Length - i - 1; j++)
    {
      if (mas[j] > mas[j + 1])
      {
        temp = mas[j];
        mas[j] = mas[j + 1];
        mas[j + 1] = temp;
      }
    }
  }
}

//Метод сортировки подсчетом
void CountSort(int[] massiv)
{
  int max = massiv.Max();
  int min = massiv.Min();
  int[] count = new int[max - min + 1];
  int j = 0;
  
  for (int i = 0; i < massiv.Length; i++)
  {
    count[massiv[i] - min]++;
  }

  for (int i = min; i <= max; i++)
  {
    while (count[i - min]-- > 0)
    {
      massiv[j] = i;
      j++;
    }
  }
}

Console.WriteLine();
int lenArr1 = ReadData("Введите длину массива: ");
int[] arr1 = Gen1DArr(lenArr1);
Print1DArr(arr1);
Console.WriteLine();
DateTime d1 = DateTime.Now;
BubbleSort(arr1);
Console.WriteLine("Сортировка методом пузырька заняла: " + (DateTime.Now - d1));
Print1DArr(arr1);

DateTime d2 = DateTime.Now;
CountSort(arr1);
Console.WriteLine("Сортировка методом подсчета заняла: " + (DateTime.Now - d2));
Print1DArr(arr1);