// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
//   элементов массива.

int globPosSum = 0;
int globNegSum = 0;

//Метод заполнения массива
int[] Gen1DArr(int len, int top, int but) //top - макс. значение эл-та; but - мин.
{
  if (but > top)
  {
    int buf = but;
    but = top;
    top = buf;
  }
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(but, top + 1);
  }
  return arr;
}

//Метод вывода результата
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

//1-й вариант метода подсчета суммы отриц. и положит. эл-ов
void NegPosSumV1(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      globPosSum += arr[i];
    }
    else
    {
      globNegSum = globNegSum + arr[i];
    }
  }
}

//2-й вариант метода подсчета суммы отриц. и положит. эл-ов
int [] NesPosSumV2(int[] arr)
{
  int positivSum = 0;
  int negotivSum = 0;
  int[] outArr = new int[2];
  for(int i=0;i<arr.Length;i++)
  {
    if(arr[i]>0)
    {
      positivSum+=arr[i];
    }
    else
    {
      negotivSum+=arr[i];
    }
  }
  outArr[0]=positivSum;
  outArr[1]=negotivSum;
  return outArr;
}

//3-й вариант метода подсчета суммы отриц. и положит. эл-ов
(int positiv, int negativ) NesPosSumV3(int[] arr)
{
  int positivSum = 0;
  int negotivSum = 0;
  for(int i=0;i<arr.Length;i++)
  {
    if(arr[i]>0)
    {
      positivSum+=arr[i];
    }
    else
    {
      negotivSum+=arr[i];
    }
  }
  return (positivSum,negotivSum);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
NegPosSumV1(testArr);
(int positiv,int negativ) sum = NesPosSumV3(testArr);
int[] res = NesPosSumV2(testArr);

Console.WriteLine("Сумма положительных чисел в массиве (v1): " + globPosSum);
Console.WriteLine("Сумма отрицательных чисел в массиве (v1): " + globNegSum);

Console.WriteLine("Сумма положительных чисел в массиве (v2): " + res[0]);
Console.WriteLine("Сумма отрицательных чисел в массиве (v2): " + res[1]);

Console.WriteLine("Сумма положительных чисел в массиве (v3): " + sum.positiv);
Console.WriteLine("Сумма отрицательных чисел в массиве (v3): " + sum.negativ);