// Задача №45
// Напишите программу, которая будет создавать копию заданного одномерного массива
// с помощью поэлементного копирования.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

//Метод заполнения массива трехзначными положительными числами
int[] Gen1DArr(int len)
{
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(10, 100);
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

//Метод копирования эл-ов массива
int[] CopyArray(int[] arr)
{
  int[] outArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    outArr[i] = arr[i];
  }
  return outArr;
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArr(lenArr);
Print1DArr(arr);
int[] cloneArr = CopyArray(arr);
Print1DArr(cloneArr);

int[] outArr = new int[arr.Length];
arr.CopyTo(outArr, 0); //метод для копирования массивов
Print1DArr(outArr);