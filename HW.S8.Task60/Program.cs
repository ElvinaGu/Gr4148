// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;
using System.Collections.Generic;

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Метод, заполняющий трехмерный массив случайными числами.
int[,,] Gen3DArray(int countArray, int countRow, int countColumn, int minValue, int maxValue)
{
  int[,,] matr = new int[countArray, countRow, countColumn];
  for (int i = 0; i < countArray; i++)
  {
    for (int j = 0; j < countRow; j++)
    {
      for (int k = 0; k < countColumn; k++)
      {
        matr[i, j, k] = new Random().Next(minValue, maxValue);
      }
    }
  }
  return matr;
}

// Метод, печатающий трехмерный массив с индексами.
void Print3DArr(int[,,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(2); k++)
      {
        Console.Write($"{matr[i, j, k]}({i},{j},{k})  ");
      }
      Console.WriteLine();
    }
  }
}

int array = ReadData("Введите кол-во массивов: ");
int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,,] arr3D = Gen3DArray(array, row, col, 10, 100);
Print3DArr(arr3D);

