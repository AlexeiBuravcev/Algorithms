using System;

namespace ConsoleApp
{
  public class Program
  {
    // Метод нахождения пары значений в массиве с заданной суммой
    public static void FindPair(int[] A, int target)
    {
      // проходим все элементы кроме последнего
      for (var i = 0; i < A.Length - 1; i++)
      {
        // проходим, начиная с i-того элемента до последнего включительно
        for (var j = i + 1; j < A.Length; j++)
        {
          // если требуемая сумма найдена, выводим результат на консоль
          if (A[i] + A[j] == target)
          {
            Console.WriteLine("Пара найдена (" + A[i].ToString() + ", " + A[j].ToString() + ")");
            return;
          }
        }
      }
      // если доходим до этого участка кода, то пара не найдена
      Console.WriteLine("Пара не найдена");
    }

    public static void Main(String[] args)
    {
      int[] arr = {8 , 7 , 2 , 5 , 3 , 1};
      var target = 10;
      FindPair(arr, target);
      Console.ReadKey();
    }
  }
}