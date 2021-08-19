using System;
using System.Collections.Generic;

namespace ConsoleApp
{
  public class Program
  {
    // Метод нахождения пары значений в массиве с заданной суммой с использованием хэширования
    public static void FindPair(int[] A, int target)
    {
      // создаем пустой словарь
      // например
      var map = new Dictionary<int, int>();
      // проходим по всему полученному массиву
      for (var i = 0; i < A.Length; i++)
      {
        // проверяем, существует ли пара `(A[i], target-A[i])`
        
        // если разница уже встречалась раннее, выводим значение на консоль и выходим
        if (map.ContainsKey(target - A[i]))
        {
          Console.Write("Пара найдена ({0}, {1})", A[map[target - A[i]]], A[i]);
          return;
        }
        // сохраняем значение индекса текущего элемента в словаре
        map[A[i]] = i;
      }
      // мы достигли этого места в коде, если пара не найдена
      Console.WriteLine("Пара не найдена");
    }
    public static void Main(String[] args)
    {
      int[] A = { 8 , 7 , 2 , 5 , 3 , 1 };
      var target = 10;
      FindPair(A, target);
      Console.ReadKey();
    }
  }
}
