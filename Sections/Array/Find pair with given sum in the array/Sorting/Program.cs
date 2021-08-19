using System;

namespace ConsoleApp
{
  public class Program
  {
    // Метод нахождения пары значений в массиве с заданной суммой
    public static void FindPair(int[] A, int target)
    {
      // сортируем массив в порядке возрастания значений
      Array.Sort(A);
      // Сохраняем два индекса, указывающих на крайние точки массива 
      var low = 0;
      var high = A.Length - 1;
      // уменьшаем пространство поиска `A[low ... high]` на каждой итерации цикла
      // цикл идет до тех пор, пока пространство поиска не будет исчерпано
      while (low < high)
      {
        // сумма найдена
        if (A[low] + A[high] == target)
        {
          Console.WriteLine("Pair found (" + A[low].ToString() + ", " + A[high].ToString() + ")");
          return;
        }
        // инкрементируем значение индекса `low`, если сумма проиндексированных элементов меньше, чем требуемая сумма;
        // декрементируем значение индекса `high`, если сумма проиндексированных элементов больше, чем требуемая сумма;
        if (A[low] + A[high] < target)
        {
          low++;
        }
        else
        {
          high--;
        }
      }
      // Мы достигли этого места в коде, если пара не найдена
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

