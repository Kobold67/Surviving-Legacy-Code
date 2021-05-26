using System;

namespace Surviving_Legacy_Code
{
   class Program
   {
      static void Main(string[] args)
      {
         var fibonacci = new Fibonacci();

         Console.WriteLine(fibonacci.CalculateAverage1());
         Console.WriteLine(fibonacci.CalculateAverage2());
         Console.ReadKey();
      }
   }
}
