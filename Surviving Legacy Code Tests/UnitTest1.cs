using Microsoft.VisualStudio.TestTools.UnitTesting;
using Surviving_Legacy_Code;

namespace Surviving_Legacy_Code_Tests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void TestAverage1()
      {
         var fibonacci = new Fibonacci();
         Assert.AreEqual(7.333333, fibonacci.CalculateAverage1(), 1E-6);
      }

      [TestMethod]
      public void TestAverage2()
      {
         var fibonacci = new Fibonacci();
         Assert.AreEqual(7.333333, fibonacci.CalculateAverage2(), 1E-6);
      }

      [TestMethod]
      public void CompareAverageResults()
      {
         var fibonacci = new Fibonacci();
         Assert.AreEqual(fibonacci.CalculateAverage1(), fibonacci.CalculateAverage2(), 1E-13);
      }


   }
}
