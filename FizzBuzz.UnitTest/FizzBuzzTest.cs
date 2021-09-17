using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Domain;

namespace FizzBuzz.UnitTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzzForInvalidValues()
        {
            string[] inputVals = new string[] { "", "A" };
            var response = FizzBuzz.Domain.FizzBuzzHelper.CalculateFizzBuzz(inputVals);
            Assert.IsTrue(response.Contains("Invalid Item"));
        }

        [TestMethod]
        public void TestForFizzValues()
        {
            string[] inputVals = new string[] { "3" };
            var response = FizzBuzz.Domain.FizzBuzzHelper.CalculateFizzBuzz(inputVals);
            Assert.IsTrue(response.Contains("Fizz"));
        }

        [TestMethod]
        public void TestForBuzzValues()
        {
            string[] inputVals = new string[] { "5" };
            var response = FizzBuzz.Domain.FizzBuzzHelper.CalculateFizzBuzz(inputVals);
            Assert.IsTrue(response.Contains("Buzz"));
        }

        [TestMethod]
        public void TestForDecimalValues()
        {
            string[] inputVals = new string[] { "5.5" };
            var response = FizzBuzz.Domain.FizzBuzzHelper.CalculateFizzBuzz(inputVals);
            Assert.IsFalse(response.Contains("Buzz"));
        }

        [TestMethod]
        public void TestForNegativeValues()
        {
            string[] inputVals = new string[] { "-5" };
            var response = FizzBuzz.Domain.FizzBuzzHelper.CalculateFizzBuzz(inputVals);
            Assert.IsTrue(response.Contains("Buzz"));
        }

        [TestMethod]
        public void TestCalculateFizzBuzz()
        {
            string[] inputVals = new string[] {"1", "3", "5", "", "A"};
            var response = FizzBuzz.Domain.FizzBuzzHelper.CalculateFizzBuzz(inputVals);
            Assert.IsNotNull(response);
        }
    }
}
