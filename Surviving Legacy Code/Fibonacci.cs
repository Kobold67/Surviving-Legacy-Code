using System.Linq;

namespace Surviving_Legacy_Code
{
   public class Fibonacci
   {
      private int[] _fibNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };

      public double CalculateAverage1()
      {
         double averageValue = 0.0;
         int count = 0;

         foreach (int fibo in _fibNum)
         {
            if (1 == fibo % 2)
            {
               count++;
               averageValue += fibo;
            }
         }
         return averageValue / count;
      }

      public double CalculateAverage2()
      {
         //return _fibNum.Where(f => 1 == f % 2 ).Average();
         return _fibNum.Average();
      }


   }
}
