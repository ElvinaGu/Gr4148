// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод заполнения массива от (0, 100)
int[] Gen1DArr(int len)
{
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(0, 100);
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
void PrintResult(string msg, int res)
{
  Console.WriteLine(msg + res);
}

// Метод подсчета значачений нечетных индексов
int SumElmtOddPos(int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i = i + 2)
  {
    sum += arr[i];
  }
  return sum;
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArr(lenArr);
Print1DArr(arr);
PrintResult("Сумма значений, находящихся на нечетных позициях: ", SumElmtOddPos(arr));

//* Найдите все пары в массиве и выведите пользователю

//Метод нахождения пар в массиве
void DoubleElmPrint(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    for (int j = 1; j < array.Length; j++)
    {
      if (array[i] == array[j] && i != j)
      {
        Console.WriteLine(array[i] + ": " + i + ", " + j);
      }
    }
  }
}

Console.WriteLine();
int lenArr2 = ReadData("Введите длину массива: ");
int[] arr2 = Gen1DArr(lenArr2);
Print1DArr(arr2);
DoubleElmPrint(arr2);