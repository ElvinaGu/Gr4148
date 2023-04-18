// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод заполнения массива вещественными числами
double[] Gen1DArr(int len)
{
  Random rnd = new Random();
  double[] arr = new double[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = Math.Round(rnd.NextDouble() * 100, 2); //NextDouble - дает случайное вещественное число
  }
  return arr;
}

//Метод вывода массива
void Print1DArr(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

double DiffMinMax(double[] array)
{
  double res = 0;
  double min = array[0];
  double max = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
  }
  res = Math.Round(max - min, 3);
  return res;
}

int lenArr = ReadData("Введите длину массива: ");
double[] arr = Gen1DArr(lenArr);
Print1DArr(arr);
double dif = DiffMinMax(arr);

Console.WriteLine("Разница между максимальным и минимальным эл-ми: " + dif);

//* Отсортируйте массив методом вставки, а затем найдите разницу 
//между первым и последним элементом.

//Метод сортировки вставкой
void InsertionSort(double[] arrS)
{
  for (int i = 1; i < arrS.Length; i++)
  {
    double k = arrS[i];
    int j = i - 1;

    while (j >= 0 && arrS[j] > k)
    {
      arrS[j + 1] = arrS[j];
      arrS[j] = k;
      j--;
    }
  }
}

Console.WriteLine();
int lenArr2 = ReadData("Введите длину массива: ");
double[] arr2 = Gen1DArr(lenArr2);
Print1DArr(arr2);
InsertionSort(arr2);
Console.WriteLine("Сортировка методом вставки:");
Print1DArr(arr2);
double dif2 = DiffMinMax(arr2);
Console.WriteLine("Разница между последним и первым эл-ом: " + dif2);